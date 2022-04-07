using ServicesCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Data
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly AppDbContext _context;

        public ServiceRepo(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creating Service
        /// </summary>
        /// <param name="service"></param>
        public void CreateService(Service service)
        {
            if(service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            _context.Services.Add(service);
        }

        /// <summary>
        /// Getting all services
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Service> GetAllServices()
        {
            return _context.Services.ToList();
        }

        /// <summary>
        /// Get Service By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Service GetServiceById(int id)
        {
            return _context.Services.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Update Service
        /// </summary>
        /// <param name="service"></param>
        public void UpdateService(Service service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            _context.Services.Update(service);
        }

        /// <summary>
        /// Delete service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteService(int id)
        {
            var result = 0;

            var service = _context.Services.FirstOrDefault(p => p.Id == id);

            if (service != null)
            {
                //Delete that service
                _context.Services.Remove(service);

                //Commit the transaction
                result = SaveChanges() ? 1 : 0;
            }
            return result;

        }

        /// <summary>
        /// Save changes
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
