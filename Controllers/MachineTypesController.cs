using Business.Abstract;
using Entities.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineTypesController : ControllerBase
    {
        IMachineTypeService _machineTypeService;
        public MachineTypesController(IMachineTypeService machineTypeService)
        {
            _machineTypeService = machineTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _machineTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _machineTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(MachineType machineType)
        {
            var result = _machineTypeService.Add(machineType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
    }
}
