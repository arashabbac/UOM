using System.Collections.Generic;
using UOM.Application.Contracts;

namespace UOM.Application
{
    public interface IDimensionService
    {
        long DefineDimension(DefineDimensionDto dto);
        List<DimensionDto> GetAllDimensions();
        DimensionDto GetById(long id);
    }
}
