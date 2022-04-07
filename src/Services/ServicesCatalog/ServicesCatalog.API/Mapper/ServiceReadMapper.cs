using ServicesCatalog.API.Dtos;
using ServicesCatalog.API.Models;
using ServicesCatalog.API.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Mapper
{
    public class ServiceReadMapper : MapperBase<Service, ServiceReadDto>
    {
        private readonly CustomerMapper customerMapper;

        protected override ServiceReadDto MapToDtoInternal(Service domainModel)
        {
            var dto = new ServiceReadDto
            {
                Id = domainModel.Id,
                Cost = domainModel.Cost,
                Description = domainModel.Description,
                HasAssignedTo = domainModel.HasAssignedTo != null ? new List<CustomerDto>(customerMapper.MapToDto(domainModel.HasAssignedTo)) : new List<CustomerDto>(),
                PinCodeCovers =  ListConverter.StringToList(domainModel.PinCodeCovers),
                ProviderContactNumber = domainModel.ProviderContactNumber,
                ProviderEmail = domainModel.ProviderEmail,
                ServiceProvider = domainModel.ServiceProvider,
                ServiceName = domainModel.ServiceName,
            };
            return dto;
        }

    }
}
