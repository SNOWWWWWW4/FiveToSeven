using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Service.ReverseAlph;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    public class ReverseAlphController
    {
        private readonly IReverseAlphService _reverseAlphService;

        public ReverseAlphController(IReverseAlphService ReverseAlphService)
        {
            _reverseAlphService = ReverseAlphService;
        }

        [HttpPost ("ReverseString/{input}")]
        public string AddInput(string input)
        {
            return _reverseAlphService.AddInput(input);
        }
    }
}