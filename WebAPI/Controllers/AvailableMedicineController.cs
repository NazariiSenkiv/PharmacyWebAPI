using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailableMedicineController : ControllerBase
    {
        IServiceManager _serviceManager;

        public AvailableMedicineController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: api/AvailableMedicine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvailableMedicine>>> Get()
        {
            try
            {
                return Ok(await _serviceManager.AvailableMedicineService.GetAllAsync<AvailableMedicine>());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/AvailableMedicine/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AvailableMedicine>> Get(int id)
        {
            try
            {
                return Ok(await _serviceManager.AvailableMedicineService.GetByIdAsync<AvailableMedicine>(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/AvailableMedicine/Sell/{id},{count}
        [HttpGet("Sell/{id},{count}")]
        public async Task<ActionResult<AvailableMedicine>> Sell(int id, int count)
        {
            try
            {
                return Ok(await _serviceManager.AvailableMedicineService.DecreaseMedicineCountAsync(id, count));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET api/AvailableMedicine/Add/{id},{count}
        [HttpGet("Add/{id},{count}")]
        public async Task<ActionResult<AvailableMedicine>> Add(int id, int count)
        {
            try
            {
                return Ok(await _serviceManager.AvailableMedicineService.IncreaseMedicineCountAsync(id, count));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
