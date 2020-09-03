using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.Menu
{
    public class ConsoleMenu : IConsoleMenu
    {
        private readonly IConsoleOptions _optionsInMenu;

        public ConsoleMenu(IConsoleOptions tempConsoleOptions)
        {
            _optionsInMenu = tempConsoleOptions;

            ShowMenu();

            string input = Console.ReadLine();
            int optionMenu = ConsoleBuffer.ProcessGeneralInput(input);

            _optionsInMenu.SelectOption(optionMenu);
        }

        public void ShowMenu()
        {
            _optionsInMenu.ShowOptions();
        }
    }
}