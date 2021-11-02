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

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);



        }

        [HttpGet("getbyid")]
        public IActionResult GetAreaById(int id)
        {
            var result = _areaService.GetById(id);

            return result.Success
                ? Ok(result.Data)
                : BadRequest(result.Message);
        }
    }
}
