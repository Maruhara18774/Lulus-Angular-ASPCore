using Lulus.BAL.Catalog.Designers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignerController : Controller
    {
        private readonly IDesginerService _desginerService;
        public DesignerController(IDesginerService desginerService)
        {
            _desginerService = desginerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var designers = await _desginerService.GetAllDesigner();
            return Ok(designers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetList(int id)
        {
            var designer = await _desginerService.GetDesigner(id);
            return Ok(designer);
        }
    }
}
