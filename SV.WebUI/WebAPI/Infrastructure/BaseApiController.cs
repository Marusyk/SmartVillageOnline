using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;
using BusinessEntities.BaseBusinessEntities;

namespace WebAPI.Infrastructure
{
	public class BaseApiController<T> : ApiController where T : BaseBusinessEntity
	{
		#region Constructors
		public BaseApiController(IService<T> entityService)
		{
			EntityService = entityService;
		}
		#endregion

		#region Protected
		protected readonly IService<T> EntityService;

		protected HttpResponseMessage ErrorMsg(HttpStatusCode statusCode, string errorMsg)
		{
			var error = new HttpError()
			{
				Message = $"code: {statusCode}",
				MessageDetail = errorMsg
			};
			return Request.CreateErrorResponse(statusCode, error);
		}
		#endregion

		#region Public

		// Get all entities
		public HttpResponseMessage Get()
		{
			var entities = EntityService.Get();

			if (entities != null)
			{
				return Request.CreateResponse(HttpStatusCode.OK, entities);
			}

			var message = $"{nameof(T)}: No content";
			return ErrorMsg(HttpStatusCode.NoContent, message);
		}
		
		// Get entity with paging
		//public HttpResponseMessage Get(int pageNo, int pageSize)
		//{
		//	throw new NotImplementedException();
		//}

		// Get entity by ID
		public HttpResponseMessage GetById(int id)
		{
			var entity = EntityService.GetById(id);
			if (entity != null)
			{
				return Request.CreateResponse(HttpStatusCode.OK, entity);
			}

			var message = $"No {nameof(T)} with ID = {id}";
			return ErrorMsg(HttpStatusCode.NoContent, message);
		}
		/*
		// Insert new entity
		public HttpResponseMessage Post([FromBody] T entity)
		{
			throw new NotImplementedException();
		}
		*/
		// Remove the entity by ID
		public HttpResponseMessage Delete(int id)
		{
			if (id <= 0)
				return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Please, specify the correct id");

			var result = EntityService.Delete(id);

			var message = $"{nameof(T)} with ID = {id} was ";
			if (result)
			{
				message += "deleted";
				return Request.CreateResponse(HttpStatusCode.OK, message);
			}
			message += "not deleted";
			return ErrorMsg(HttpStatusCode.InternalServerError, message);
		}

		//Update the entity
		public HttpResponseMessage Put(int id, [FromBody] T entity)
		{
			if (id <= 0)
				return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Please, specify the correct id");

			var result = EntityService.Update(id, entity);
			return result ?
				Request.CreateResponse(HttpStatusCode.OK, "Updated") :
				ErrorMsg(HttpStatusCode.InternalServerError, "Not updated!");
		}
		#endregion
	}
}