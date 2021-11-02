using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevitWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WallsController : ControllerBase
    {
        private readonly IWallService _wallService;

        public WallsController(IWallService wallService)
        {
            _wallService = wallService;
        }

        [HttpGet]
        public IActionResult GetWalls()
        {
            var result = _wallService.GetAll();

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetWallById(int id)
        {
            var result = _wallService.GetById(id);

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);

        }

    }
}
