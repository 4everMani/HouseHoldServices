using Microsoft.AspNetCore.Mvc;
using ServicesCatalog.API.Data;
using ServicesCatalog.API.Dtos;
using ServicesCatalog.API.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepo _repo;

        private readonly ServiceReadMapper _serviceReadMapper;

        private readonly ServiceCreateMapper _serviceCreateMapper;

        public ServicesController(IServiceRepo serviceRepo, ServiceReadMapper serviceReadMapper, ServiceCreateMapper serviceCreateMapper)
        {
            _repo = serviceRepo;
            _serviceCreateMapper = serviceCreateMapper;
            _serviceReadMapper = serviceReadMapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ServiceReadDto>> GetServices()
        {
            var services = _repo.GetAllServices();

            return Ok(new List<ServiceReadDto>(_serviceReadMapper.MapToDto(services)));

        }

        [HttpGet("{id}", Name = "GetServiceById")]
        public ActionResult<ServiceReadDto> GetServiceById(int id)
        {
            var service = _repo.GetServiceById(id);
            if (service != null)
            {
                return Ok(_serviceReadMapper.MapToDto(service));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<ServiceReadDto> CreateService(ServiceCreateDto service)
        {
            var input = _serviceCreateMapper.MapToModel(service);

            _repo.CreateService(input);
            _repo.SaveChanges();

            var serviceDto = _serviceReadMapper.MapToDto(input);
            return CreatedAtRoute(nameof(GetServiceById), new { id = serviceDto.Id }, serviceDto);
        }






    }
}
