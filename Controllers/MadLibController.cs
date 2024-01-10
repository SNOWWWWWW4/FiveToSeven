using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Service.MadLib;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly IMadLibService _madLibService;

        public MadLibController(IMadLibService MadLibService)
        {
            _madLibService = MadLibService;
        }

        [HttpPost ("story/{title}/{femName}/{guyName}/{supName}/{color}/{feeling}/{size}/{temp}/{faceExpression}/{fareWell}")]

        public string AddStoryInputs(string title, string femName, string guyName, string supName, string color, string feeling, string size, string temp, string faceExpression, string fareWell)
        {
            return _madLibService.AddStoryInputs(title, femName,guyName,supName, color, feeling, size, temp, faceExpression, fareWell);
        }
    }
}