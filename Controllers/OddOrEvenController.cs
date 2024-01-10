using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Service.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly IOddOrEvenService _oddOrEvenService;

        public OddOrEvenController(IOddOrEvenService OddOrEvenService)
        {
            _oddOrEvenService = OddOrEvenService;
        }

        [HttpPost("Numbers/{num1}")]

        public string AddInputs(string num1)
        {
            return _oddOrEvenService.AddInputs(num1);
        }
    }
}