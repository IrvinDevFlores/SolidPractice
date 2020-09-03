using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.Menu
{
    public class ConsoleBuffer
    {
        public static void PrintOuput(string message)
        {
            Console.WriteLine(message);
        }

        public static int ProcessGeneralInput(string input)
        {
            int intOuput;

            bool exit = true;

            bool yesConverted = Int32.TryParse(input, out intOuput);
            bool validNumber = intOuput > 0;
            if (!yesConverted)
            {
                Console.WriteLine("Invalid option");
                return 0;
            }
            if (!validNumber)
            {
                Console.WriteLine("Invalid number");
                return 0;
            }

            return intOuput;
        }
    }
}