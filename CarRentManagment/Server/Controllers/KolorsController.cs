using CarRentManagment.Server.IRepository;
using CarRentManagment.Shared.Domain;

using Microsoft.AspNetCore.Mvc;

namespace CarRentManagment.Server.Controllers
{
    public class KolorsController : Controller
    {
        readonly IUnitOfWork _unitOfWork;
        public KolorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _unitOfWork.Kolors.GetAll();
            return Ok(result);
        }

        // GET api/<KolorsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _unitOfWork.Kolors.Get(s => s.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/<KolorsController>
        [HttpPost]
        public async Task<ActionResult<Kolor>> Post(Kolor Kolor)
        {
            await _unitOfWork.Kolors.Insert(Kolor);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Get", new { id = Kolor.Id }, Kolor);

        }

        // PUT api/<KolorsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Kolor Kolor)
        {
            if (id != Kolor.Id)
            {
                return NotFound();
            }

            _unitOfWork.Kolors.Update(Kolor);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // DELETE api/<KolorsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _unitOfWork.Kolors.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }
    }
}
