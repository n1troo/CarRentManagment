using CarRentManagment.Server.IRepository;
using CarRentManagment.Shared.Domain;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentManagment.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

      
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _unitOfWork.Colors.GetAll();
            return Ok(result);
        }

        // GET api/<ColorsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _unitOfWork.Colors.Get(s=>s.Id == id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/<ColorsController>
        [HttpPost]
        public async Task<IActionResult> Post(Color color)
        {
            await _unitOfWork.Colors.Insert(color);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Get", new { id = color.Id }, color);

        }

        // PUT api/<ColorsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Color color)
        {
            if (id != color.Id)
            {
                return NotFound();
            }

            _unitOfWork.Colors.Update(color);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // DELETE api/<ColorsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }
    }
}
