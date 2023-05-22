using Hotelverwaltung.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotelverwaltung.WebAPI.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private DbManager _context;

        public  RoomController(DbManager context)
        {
            this._context = context;
        }
        [HttpGet]
        [Route("allRooms")]
        public async Task<IActionResult> getAllRooms()
        {
            return new JsonResult(await _context.Rooms.ToListAsync());
        }
    }
}
