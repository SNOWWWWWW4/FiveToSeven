using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Service.MadLib
{
    public class MadLibService : IMadLibService
    {
        public string AddStoryInputs(string title, string femName, string guyName, string supName, string color, string feeling, string size, string temp, string faceExpression, string fareWell)
        {
            return $"This is {title}, the Story you created: \nBelow them, music echoed through the alleyways and streets of the {size} city. \n{femName} looked down at the dancing people below. How strange this night feels, {femName} thought to herself. \nFrom the corner of her eye, she saw {guyName} tilt his head to one side, he looked {feeling}. \n{guyName}, as if he had accepted his fate, let out a sigh and looked up at the {color} night sky. \nA {temp} breeze sweeped through the rooftop. From the other side {supName} yells, '{femName}, hurry up we have to go!'. \n{guyName} reached out towards her but stopped himself and yelled behind her, '{fareWell}'. \nAnd she {faceExpression} back at him.";
        }
    }
}