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
    public class AreasController : ControllerBase
    {
        private readonly IAreaService _areaService;
        public AreasController(IAreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet]
        public IActionResult GetAreas()
        {
            var result = _areaService.GetAll();
            return Ok(result);
        }

        [HttpGet("{areaNumber}")]
        public IActionResult GetRoomByNumber(int areaNumber)
        {
            var result = _areaService.GetByNumber(areaNumber);

            return Ok(result);
        }
    }
}
