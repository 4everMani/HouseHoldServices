using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Utilities
{
    public abstract class MapperBase<TDomainModel, TDto>
    {
        public TDto MapToDto(TDomainModel domainModel)
        {
            try
            {
                return this.MapToDtoInternal(domainModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TDto> MapToDto(IEnumerable<TDomainModel> inputModels)
        {
            foreach (var model in inputModels)
            {
                yield return this.MapToDto(model);
            }
        }

        public TDomainModel MapToModel(TDto dto)
        {
            try
            {
                return this.MapToModelInternal(dto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TDomainModel> MapToModel(IEnumerable<TDto> inputDtos)
        {
            foreach(var dto in inputDtos)
            {
                yield return this.MapToModel(dto);
            }
        }

        protected virtual TDomainModel MapToModelInternal(TDto dto)
        {
            throw new Exception("method not implemented");
        }

        protected virtual TDto MapToDtoInternal(TDomainModel domainModel)
        {
            throw new Exception("method not implemented");
        }
    }
}
