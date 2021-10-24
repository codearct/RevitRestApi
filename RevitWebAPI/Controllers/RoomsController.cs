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
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        [HttpGet]
        public IActionResult GetRooms()
        {
            var result = _roomService.GetAll();
            return Ok(result);
        }

        [HttpGet("{roomNumber}")]
        public IActionResult GetRoomByNumber(int roomNumber)
        {
            var result = _roomService.GetByNumber(roomNumber);

            return Ok(result);
        }
    }
}
