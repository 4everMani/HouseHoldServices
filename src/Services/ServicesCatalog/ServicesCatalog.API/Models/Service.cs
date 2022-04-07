using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Models
{
    public class Service
    {
        [Key]
        [Required]
        public int Id { get; set; }

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
        public string PinCodeCovers { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Customer> HasAssignedTo { get; set; }
    }
}
