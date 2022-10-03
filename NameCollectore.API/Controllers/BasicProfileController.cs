using Calculator.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NameCollector.Model.ViewModel;
using NameCollector.Service.Interface;
using System;
using System.Threading.Tasks;

namespace NameCollectore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicProfileController : ControllerBase
    {
        private readonly IBasicProfileService _basicProfileService;
       public BasicProfileController(IBasicProfileService basicProfileService)
        {
            _basicProfileService = basicProfileService;
        }

        [HttpPost("CreateProfile")]
        public async Task<IActionResult> CreateProfile(BasicProfileCreateRequestViewModel model)
        {
            var result = await _basicProfileService.CreateProfile(model);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response =  _basicProfileService.GetById(id);
            return Ok(response);
        }

        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile(BasicProfileUpdateViewModel model)
        {
            var response = await _basicProfileService.UpdateProfile(model);
            return Ok(response);
        }

        [HttpDelete("DeleteProfile")]
        public async Task<IActionResult> DeleteProfile(Guid id)
        {
            var response = await _basicProfileService.DeleteProfile(id);
            return Ok(response);
        }


        [HttpPost("GetSquareArea")]
        public async Task<IActionResult> GetSquareArea(AreaOfSquareViewModel model)
        {
            var result = _basicProfileService.GetSquareArea(model);
            return Ok(result);
        }
        //[HttpGet("GetAll")]
        ////public IActionResult GetAll()
        //{
        //    var response = _basicProfileService.GetAll();
        //    return Ok(response);
        //}
    }
}
