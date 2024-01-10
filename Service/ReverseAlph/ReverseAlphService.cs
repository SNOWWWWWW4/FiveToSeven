using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Service.ReverseAlph
{
    public class ReverseAlphService : IReverseAlphService
    {
        public string AddInput(string input)
        {
            string inputList = "";

            for(int i = input.Length-1; i >= 0; i--)
            {
                inputList += input[i];
            }

            return inputList;
        }
    }
}