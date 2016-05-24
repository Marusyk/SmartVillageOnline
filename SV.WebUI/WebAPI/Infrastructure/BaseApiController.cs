using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using BusinessEntities.BaseBusinessEntities;
using Infrastructure.Interfaces;

namespace WebAPI.Infrastructure {
	public class BaseApiController<T> : ApiController where T: BaseBusinessEntities
	{
	    #region Constructors
		public BaseApiController(IServices<T> entityServices) 
		{
			EntityServices = entityServices;
		}
		#endregion

		#region Protected
		protected readonly IServices<T> EntityServices;

		protected string GenericTypeName => typeof(T).Name;

		protected HttpResponseMessage ErrorMsg(HttpStatusCode statusCode, string errorMsg) {
			var error = new HttpError() {
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
			var entities = EntityServices.GetAll();

			if (entities != null) 
			{
				return Request.CreateResponse(HttpStatusCode.OK, entities);
			}

			var message = $"{GenericTypeName}: No content";
			return ErrorMsg(HttpStatusCode.NoContent, message);
		}

		// Get entity with paging
		public HttpResponseMessage Get(int pageNo, int pageSize) 
		{
			throw new NotImplementedException();
		}

		// Get entity by ID
		public HttpResponseMessage GetById(int id) 
		{
			var entity = EntityServices.GetById(id);
			if (entity != null) 
			{
				return Request.CreateResponse(HttpStatusCode.OK, entity);
			}

			var message = $"No {GenericTypeName} with ID = {id}";
			return ErrorMsg(HttpStatusCode.NoContent, message);
		}

		// Insert new entity
		public HttpResponseMessage Post([FromBody] T entity) 
		{
			throw new NotImplementedException();
		}

		// Remove the entity by ID
		public HttpResponseMessage Delete(int id) {
			if (id <= 0)
				return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Please, specify the correct id");
			var result = EntityServices.Delete(id);
			var message = $"{GenericTypeName} with ID = {id} was " + (result ? "deleted" : "not deleted");
			return result ? Request.CreateResponse(HttpStatusCode.OK, message) : ErrorMsg(HttpStatusCode.InternalServerError, message);
		}

		// Update the entity
		public HttpResponseMessage Put(int id, [FromBody] T entity) 
		{
			if (id <= 0)
				return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Please, specify the correct id");
			var result = EntityServices.Update(id, entity);
			return result ? Request.CreateResponse(HttpStatusCode.OK, "GOOOD") : ErrorMsg(HttpStatusCode.InternalServerError, "FAIL"); ;
		}
		#endregion
	}
}