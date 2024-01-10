using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Service.ReverseNum
{
    public class ReverseNumService : IReverseNumService
    {
        public string AddInput(string number)
        {
            double num = 0;
            bool success = double.TryParse(number, out num);

            if(success)
            {
                string numList = "";

                for(int i = number.Length-1; i > 0; i--)
                {
                    numList += number[i];
                }

                return numList;

            }else{
                return "Please enter a number";
            }

        }
    }
}