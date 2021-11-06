using System.Collections.Generic;
using UOM.Application.Contracts;
using UOM.Domain.Models.Dimensions;

namespace UOM.Application
{
    public class DimensionService : IDimensionService
    {
        private readonly IDimensionRepository _dimensionRepository;

        public DimensionService(IDimensionRepository dimensionRepository)
        {
            _dimensionRepository = dimensionRepository;
        }

        public long DefineDimension(DefineDimensionDto dto)
        {
            var dimension = new Dimension(dto.Name, dto.Symbol);
            _dimensionRepository.Add(dimension);
            return dimension.Id;
        }

        public List<DimensionDto> GetAllDimensions()
        {
            throw new System.NotImplementedException();
        }

        public DimensionDto GetById(long id)
        {
            var dimension = _dimensionRepository.GetById(id);
            return new DimensionDto
            {
                Id = dimension.Id,
                Name = dimension.Name,
                Symbol = dimension.Symbol,
            };
        }
    }

    //Domain        ==> Business Logic
    //Application   ==> Application Logic (use-case orchestration)
}
