using Business.Abstract;
using MachineGoDemo.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        IMachineService _machineService;

        public MachinesController(IMachineService productService)
        {
            _machineService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _machineService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _machineService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Machine machine)
        {
            var result = _machineService.Add(machine);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
      
        //makine listele kismi icin
        [HttpGet("getmachinedetail")]
        public IActionResult GetMachineDetails()
        {
            var result = _machineService.GetMachineDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
  