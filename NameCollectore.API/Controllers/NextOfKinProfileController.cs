using Microsoft.AspNetCore.Mvc;
using NameCollector.Model.ViewModel;
using NameCollector.Service.Interface;

namespace NameCollector.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NextOfKinProfileController : ControllerBase
    {
        private readonly INextOfKinProfileService _nextOfKinProfileService;
        public NextOfKinProfileController(INextOfKinProfileService nextOfKinProfileService)
        {
            _nextOfKinProfileService = nextOfKinProfileService;
        }
        [HttpPut("CreateNextOfKinProfile")]
        public IActionResult CreateNextOfKinProfile(NextOfKinProfileRequestViewModel model)
        {
            var result = _nextOfKinProfileService.CreateNextOfKinProfile(model);
            return Ok(result);
        }
    }
}
