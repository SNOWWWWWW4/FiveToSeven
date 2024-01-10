using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Service.MadLib
{
    public interface IMadLibService
    {
        string AddStoryInputs(string title, string femName, string guyName, string supName, string color, string feeling, string size, string temp, string faceExpression, string fareWell);
    }
}