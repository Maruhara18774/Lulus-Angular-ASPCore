using Lulus.BAL.Catalog.Occations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccationController : Controller
    {
        private readonly IOccationService _occationService;
        public OccationController(IOccationService occationService)
        {
            _occationService = occationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _occationService.GetAll();
            return Ok(result);
        }
    }
}
