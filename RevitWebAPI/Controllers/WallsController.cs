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

        [HttpGet("{walltype}")]
        public IActionResult GetWallsByType(string wallType)
        {
            var result = _wallService.GetByType(wallType);

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);

        }

    }
}
