using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevitWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoorsController : ControllerBase
    {
        private readonly IDoorService _doorService;

        public DoorsController(IDoorService doorService)
        {
            _doorService = doorService;
        }

        [HttpGet]
        public IActionResult GetDoors()
        {
            var result = _doorService.GetAll();

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetDoorById(int id)
        {
            var result = _doorService.GetById(id);

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);
        }
    }
}
