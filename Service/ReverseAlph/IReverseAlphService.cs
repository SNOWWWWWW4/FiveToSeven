using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Service.ReverseAlph
{
    public interface IReverseAlphService
    {
        string AddInput(string input);
    }
}