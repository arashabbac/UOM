using Microsoft.AspNetCore.Mvc;
using UOM.Application;

namespace UOM.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DimensionsController : ControllerBase
    {
        private readonly IDimensionService _dimensionService;

        public DimensionsController(IDimensionService dimensionService)
        {
            _dimensionService = dimensionService;
        }

        public IActionResult Post(DefineDimensionDto dto)
        {
            _dimensionService.DefineDimension(dto);
            return Ok();
        }
    }
}
