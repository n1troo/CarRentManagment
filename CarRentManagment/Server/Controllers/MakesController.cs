using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentManagment.Server.Data;
using CarRentManagment.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CarRentManagment.Server.IRepository;

namespace CarRentManagment.Server.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
       
        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes =  await _unitOfWork.Makes.GetAll();
            return Ok(makes); 
        }

        // GET:/Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            var make = await _unitOfWork.Makes.Get(s=>s.Id == id);
            if (make == null)
            {
                return NotFound();
            }
            return Ok(make);
        }

        // PUT: Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Makes.Update(make);

            try
            {
                await _unitOfWork.Save(HttpContext);   
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!await MakeExists(id))
                {
                    NotFound();
                }
                else { throw; }
            }

            return NoContent();
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMake(Make make)
        {
            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var result = await _unitOfWork.Makes.Get(s => s.Id == id);
            return result == null;
        }
    }
}
