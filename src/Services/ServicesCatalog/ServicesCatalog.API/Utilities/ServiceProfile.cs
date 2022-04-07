using AutoMapper;
using ServicesCatalog.API.Dtos;
using ServicesCatalog.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Utilities
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            // source => target
            CreateMap<Service, ServiceReadDto>();
            CreateMap<ServiceCreateDto, Service>();
        }
    }
}
