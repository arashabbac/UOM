using UOM.Domain.Models.Dimensions;

namespace UOM.Application
{
    public class DimensionService
    {
        private readonly IDimensionRepository _dimensionRepository;

        public DimensionService(IDimensionRepository dimensionRepository)
        {
            _dimensionRepository = dimensionRepository;
        }

        public void DefineDimension(DefineDimensionDto dto)
        {
            var id = _dimensionRepository.NextId();
            var dimension = new Dimension(id, dto.Name, dto.Symbol);
            _dimensionRepository.Add(dimension);
        }
    }

    //Domain        ==> Business Logic
    //Application   ==> Application Logic (use-case orchestration)
}
