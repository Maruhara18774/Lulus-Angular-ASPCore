using Lulus.Data.Enums;
using Lulus.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommonController : Controller
    {
        [HttpGet]
        public IActionResult GetAllLength()
        {
            var arr = new List<SingleEnumViewModel>();
            arr.Add(new SingleEnumViewModel((int)LengthState.HiLow, LengthState.HiLow.ToString()));
            arr.Add(new SingleEnumViewModel((int)LengthState.Maxi, LengthState.Maxi.ToString()));
            arr.Add(new SingleEnumViewModel((int)LengthState.Midi, LengthState.Midi.ToString()));
            arr.Add(new SingleEnumViewModel((int)LengthState.Mini, LengthState.Mini.ToString()));
            return Ok(arr);
        }
        [HttpGet]
        public IActionResult GetAllSleeveLength()
        {
            var arr = new List<SingleEnumViewModel>();
            arr.Add(new SingleEnumViewModel((int)SleeveLengthState.LongSleeve, SleeveLengthState.LongSleeve.ToString()));
            arr.Add(new SingleEnumViewModel((int)SleeveLengthState.ShortSleeve, SleeveLengthState.ShortSleeve.ToString()));
            arr.Add(new SingleEnumViewModel((int)SleeveLengthState.Strapless, SleeveLengthState.Strapless.ToString()));
            arr.Add(new SingleEnumViewModel((int)SleeveLengthState.Tank, SleeveLengthState.Tank.ToString()));
            return Ok(arr);
        }
    }
}
