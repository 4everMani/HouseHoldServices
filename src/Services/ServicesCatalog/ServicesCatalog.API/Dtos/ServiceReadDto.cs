using ServicesCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Dtos
{
    public class ServiceReadDto
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public string ServiceProvider { get; set; }

        public string Cost { get; set; }

        public string ProviderEmail { get; set; }

        public decimal ProviderContactNumber { get; set; }

        public IEnumerable<int> PinCodeCovers { get; set; }

        public string Description { get; set; }

        public List<CustomerDto> HasAssignedTo { get; set; }
    }
}
