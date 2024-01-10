using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Service.ReverseNum;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    public class ReverseNumController
    {
        private readonly IReverseNumService _reverseNumService;

        public ReverseNumController(IReverseNumService ReverseNumService)
        {
            _reverseNumService = ReverseNumService;
        }

        [HttpPost ("ReverseNum/{number}")]
        public string AddInput(string number)
        {
            return _reverseNumService.AddInput(number);
        }
    }
}