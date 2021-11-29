using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Service
    {
        public class ServiceStorage
        {
            private Dictionary<int, Service> Services { get; } = new Dictionary<int, Service>();

            public void Create(Service service)
            {
                Services.Add(service.ServiceId, service);
            }

            public Service Read(int serviceId)
            {
                return Services[serviceId];
            }

            public Service Update(int serviceId, Service newService)
            {
                Services[serviceId] = newService;
                return Services[serviceId];
            }

            public bool Delete(int serviceId)
            {
                return Services.Remove(serviceId);
            }

        }
    }
}

