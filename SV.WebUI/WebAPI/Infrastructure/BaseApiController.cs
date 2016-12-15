using System;
using System.Linq;
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

		private Uri GetCreatedEntityLink(int id)
		{
			return new Uri(Url.Link("DefaultApi", new { id }));
		}
		#endregion

		#region Public

		// Get all entities
		public virtual HttpResponseMessage Get()
		{
			var entities = EntityService.GetAll();

			if (entities != null)
			{
				return Request.CreateResponse(HttpStatusCode.OK, entities);
			}

			var message = $"{nameof(T)}: No content";
			return ErrorMsg(HttpStatusCode.NoContent, message);
		}

		// Get entity with paging
		public virtual HttpResponseMessage Get(int pageNo, int pageSize)
		{
			var paginatedEntities = EntityService.Get(pageNo, pageSize);

			if (!paginatedEntities.Any())
			{
				var message = $"{nameof(T)}: No content";
				return ErrorMsg(HttpStatusCode.NoContent, message);
			}

			var response = Request.CreateResponse(HttpStatusCode.OK, paginatedEntities);
			response.Headers.Add("X-Paging-PageNo", paginatedEntities.PageIndex.ToString());
			response.Headers.Add("X-Paging-PageSize", paginatedEntities.PageSize.ToString());
			response.Headers.Add("X-Paging-PageCount", paginatedEntities.TotalPageCount.ToString());
			response.Headers.Add("X-Paging-TotalRecordCount", paginatedEntities.TotalCount.ToString());
			response.Headers.Add("X-Paging-HasPreviousPage", paginatedEntities.HasPreviousPage.ToString());
			response.Headers.Add("X-Paging-HasNextPage", paginatedEntities.HasNextPage.ToString());
			return response;
		}

		// Get entity by ID
		public virtual HttpResponseMessage GetById(int id)
		{
			var entity = EntityService.GetById(id);
			if (entity != null)
			{
				return Request.CreateResponse(HttpStatusCode.OK, entity);
			}

			var message = $"No {nameof(T)} with ID = {id}";
			return ErrorMsg(HttpStatusCode.NotFound, message);
		}

		// Insert new entity
		public virtual HttpResponseMessage Post([FromBody] T entity)
		{
			var id = EntityService.Insert(entity);

			if (id <= default(int)) 
				return ErrorMsg(HttpStatusCode.BadRequest, "Please, specify the correct entity");

			var response = Request.CreateResponse(HttpStatusCode.Created, entity);
			response.Headers.Location = GetCreatedEntityLink(id);
			return response;
		}

		// Remove the entity by ID
		public virtual HttpResponseMessage Delete(int id)
		{
			var result = EntityService.Delete(id);

			return result ?
				Request.CreateResponse(HttpStatusCode.NoContent, $"{nameof(T)} with ID = {id} was deleted") :
				ErrorMsg(HttpStatusCode.NotFound, "Please, specify the correct id");
		}

		//Update the entity
		public virtual HttpResponseMessage Put(int id, [FromBody] T entity)
		{
			if (entity == null || entity.Id != id)
			{
				return ErrorMsg(HttpStatusCode.BadRequest, "Please, specify the correct entity");
			}
			var result = EntityService.Update(id, entity);

			return result ?
				Request.CreateResponse(HttpStatusCode.NoContent) :
				ErrorMsg(HttpStatusCode.InternalServerError, "Please, specify the correct entity");
		}
		#endregion
	}
}