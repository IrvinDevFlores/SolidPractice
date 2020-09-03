using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.Menu
{
    public delegate void controler();
    public interface IConsoleOptions
    {

        int GetSelectedOption();

        void SelectOption(int option);

        void ShowOptions();

    }
    
}
