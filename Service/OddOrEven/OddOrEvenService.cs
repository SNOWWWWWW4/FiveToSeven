using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Service.OddOrEven
{
    public class OddOrEvenService : IOddOrEvenService
    {
        public string AddInputs(string num1)
        {
            int numOne = 0;
            bool success =Int32.TryParse(num1, out numOne);

            if(success)
            {
                if( numOne % 2 == 0)
                {
                    return $"{numOne} is an even number";
                }else{
                    return $"{numOne} is an odd number";
                }
            }else{
                return "Please enter a whole number";
            }
        }
    }
}