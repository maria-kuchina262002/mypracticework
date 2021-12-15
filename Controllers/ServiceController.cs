using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Service")]
    public class ServiceController : ControllerBase
    {
        [HttpPut]
        public Service Create(Service service)
        {
            Storage.ServiceStorage.Create(service);
            return service;
        }

        [HttpGet]
        public Service Read(int serviceId)
        {
            return Storage.ServiceStorage.Read(serviceId);
        }

        [HttpPost]
        public Service Update(int serviceId, Service newService)
        {
            return Storage.ServiceStorage.Update(serviceId, newService);
        }

        [HttpDelete]
        public bool Delete(int serviceId)
        {
            return Storage.ServiceStorage.Delete(serviceId);
        }

    }
