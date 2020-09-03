using SOLID_DYEORDER.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOptions c = new ConsoleOptions();
            ConsoleMenu m = new ConsoleMenu(c);

            Console.ReadKey();
            
        }
    }
}
