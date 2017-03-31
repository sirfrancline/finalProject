using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
   public static class Helpers
    {

        public static int GetIntegerOptionFromUser(int minValue, int maxValue)
        {
            var userInput = Console.ReadLine();
            var retry = true;
            int option;
            //chec user input
            while (retry)
            {
                var parseResult = int.TryParse(userInput, out option);
                if (parseResult)
                {
                    //check min max as inpru is valid
                    if (minValue <= option && option <= maxValue)
                    {
                        retry = false; // return terminate loop
                        return option;
                    }
                }

                Console.WriteLine($"Please provide valid input, min:{minValue}, max:{maxValue}");
                userInput = Console.ReadLine();
            }

            throw new IndexOutOfRangeException();
        }

    }
}
