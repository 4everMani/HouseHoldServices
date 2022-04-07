using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Dtos
{
    public class ServiceCreateDto
    {
        [Required]
        public string ServiceName { get; set; }

        [Required]
        public string ServiceProvider { get; set; }

        [Required]
        public string Cost { get; set; }

        [Required]
        public string ProviderEmail { get; set; }

        [Required]
        public decimal ProviderContactNumber { get; set; }

        [Required]
        public IEnumerable<int> PinCodeCovers { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
