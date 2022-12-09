using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;
using WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        IServiceManager _serviceManager;

        public MedicineController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: api/Medicine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicine>>> Get()
        {
            try
            {
                return Ok(await _serviceManager.MedicineService.GetAllAsync<Medicine>());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/Medicine/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicine>> Get(int id)
        {
            try
            {
                return Ok(await _serviceManager.MedicineService.GetByIdAsync<Medicine>(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/Medicine
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] MedicineDTO medicineDto)
        {
            try
            {
                return Ok(await _serviceManager.MedicineService.CreateAsync<MedicineDTO>(medicineDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/Medicine/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] MedicineDTO categoryDto)
        {
            try
            {
                await _serviceManager.MedicineService.UpdateByIdAsync<MedicineDTO>(id, categoryDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/Medicine/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _serviceManager.MedicineService.DeleteByIdAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
