using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities.Dictionaries;
using Infrastructure;
using Infrastructure.Interfaces;

namespace WebAPI.Controllers
{
    public class AnimalController : ApiController
    {
        private IServices<AnimalEntity> _animalServices;

        public AnimalController(IServices<AnimalEntity> animalServices)
        {
            _animalServices = animalServices;
        }

        public HttpResponseMessage Get(int id)
        {
            var animal = _animalServices.GetById(id);
            return animal != null ? Request.CreateResponse(HttpStatusCode.OK, animal) : Request.CreateErrorResponse(HttpStatusCode.NotFound, "Prosucts not found");
        }
    }
}
