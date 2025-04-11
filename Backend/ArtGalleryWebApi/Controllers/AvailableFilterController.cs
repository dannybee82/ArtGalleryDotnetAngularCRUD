using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AvailableFilterController : ControllerBase
    {
        private readonly IAvailableFilterService _availableFilterService;

        public AvailableFilterController(IAvailableFilterService availableFilterService)
        {
            _availableFilterService = availableFilterService;
        }

        [HttpGet("GetAvailableFilters")]
        public async Task<IActionResult> GetAvailableFilters([FromQuery] FilterDataDto filter)
        {
            try
            {
                var items = await _availableFilterService.GetAvailableFilters(filter);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}