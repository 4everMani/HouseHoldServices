using ServicesCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Data
{
    public interface IServiceRepo
    {
        bool SaveChanges();

        IEnumerable<Service> GetAllServices();

        Service GetServiceById(int id);

        void CreateService(Service service);

        void UpdateService(Service service);

        int DeleteService(int id);

    }
}
