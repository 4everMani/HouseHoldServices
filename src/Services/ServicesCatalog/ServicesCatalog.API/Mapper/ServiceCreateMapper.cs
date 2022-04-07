using ServicesCatalog.API.Dtos;
using ServicesCatalog.API.Models;
using ServicesCatalog.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Mapper
{
    public class ServiceCreateMapper : MapperBase<Service, ServiceCreateDto>
    {
        protected override Service MapToModelInternal(ServiceCreateDto dto)
        {
            var model = new Service
            {
                Cost = dto.Cost,
                Description = dto.Description,
                PinCodeCovers = ListConverter.ListToString(dto.PinCodeCovers),
                ProviderContactNumber = dto.ProviderContactNumber,
                ProviderEmail = dto.ProviderEmail,
                ServiceName = dto.ServiceName,
                ServiceProvider = dto.ServiceProvider,
            };
            return model;
        }
    }
}
