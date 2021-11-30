using CarRentManagment.Server.IRepository;
using CarRentManagment.Shared.Domain;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentManagment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var restult = await _unitOfWork.Customers.GetAll();
            return Ok(restult);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = _unitOfWork.Customers.Get(s=>s.Id == id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<Customer>> Post(Customer customer)
        {
            if(customer == null) { return BadRequest(); }
            await _unitOfWork.Customers.Insert(customer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("Get", new {id = customer.Id, customer});
        }

 
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Customer customer)
        {
            if(id != customer.Id) { return BadRequest(); }

            _unitOfWork.Customers.Update(customer);
            await _unitOfWork.Save(HttpContext);    

            return Ok();
        }

      
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(HttpContext);
        }
    }
}
