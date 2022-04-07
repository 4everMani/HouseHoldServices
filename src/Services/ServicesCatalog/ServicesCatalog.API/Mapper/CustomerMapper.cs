using ServicesCatalog.API.Dtos;
using ServicesCatalog.API.Models;
using ServicesCatalog.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Mapper
{
    public class CustomerMapper : MapperBase<Customer, CustomerDto>
    {
        protected override CustomerDto MapToDtoInternal(Customer domainModel)
        {
            var dto = new CustomerDto
            {
                Address = domainModel.Address,
                ContactNumber = domainModel.ContactNumber,
                Email = domainModel.Email,
                Name = domainModel.Name,
                PinCode = domainModel.PinCode,
            };
            return dto;
        }

        protected override Customer MapToModelInternal(CustomerDto dto)
        {
            var model = new Customer
            {
                Address = dto.Address,
                ContactNumber = dto.ContactNumber,
                Email = dto.Email,
                Name = dto.Name,
                PinCode = dto.PinCode,
            };
            return model;
        }
        
    }
}
