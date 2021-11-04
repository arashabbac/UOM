using Microsoft.AspNetCore.Mvc;
using UOM.Application;
using UOM.Application.Contracts;

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

        [HttpPost]
        public IActionResult Post(DefineDimensionDto dto)
        {
            var dimensionId =_dimensionService.DefineDimension(dto);
            return Ok(dimensionId);
        }

        [HttpGet("{id}")]
        public ActionResult<DimensionDto> Get(long id)
        {
            var dimension = _dimensionService.GetById(id);
            return Ok(dimension);
        }
    }
}
