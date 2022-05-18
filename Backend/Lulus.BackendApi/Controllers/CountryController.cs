using Lulus.BAL.Catalog.Country;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryService _service;
        public CountryController(ICountryService service)
        {
            _service = service;
        }
        [HttpGet("Countries")]
        public async Task<IActionResult> GetAllCountry()
        {
            var result = await _service.GetAllCountry();
            return Ok(result);
        }
        [HttpGet("Cities/{id}")]
        public async Task<IActionResult> GetAllCity(int id)
        {
            var result = await _service.GetAllCity(id);
            return Ok(result);
        }
        [HttpGet("Provinces/{id}")]
        public async Task<IActionResult> GetAllProvince(int id)
        {
            var result = await _service.GetAllProvince(id);
            return Ok(result);
        }

    }
}
