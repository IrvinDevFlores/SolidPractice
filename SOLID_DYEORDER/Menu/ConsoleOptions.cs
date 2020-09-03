using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_DYEORDER.DyeOrderComponents;

namespace SOLID_DYEORDER.Menu
{
    public class ConsoleOptions : IConsoleOptions
    {
        public delegate void controlerMethod();

        public Dictionary<int, Dictionary<string, controlerMethod>> options;

        public int selectedOption;

        public ConsoleOptions()
        {
            selectedOption = 0;

            options = new Dictionary<int, Dictionary<string, controlerMethod>>();
            DyeOrder dye = new DyeOrder();
            AddOption(1, "Crear orden", dye.CreateDyeOrder);
            AddOption(2, "Consultar orden", null);
            AddOption(3, "Cancelar orden", null);
            AddOption(4, "Salir", null);
        }

        public void InvokeOptionMethod(int index)
        {
            foreach (var item in options[index])
            {
                if ((index > 0 && index <= options.Count))
                    item.Value.Invoke();
                else
                    Console.WriteLine("No existe metodo");
            }
        }

        public void AddOption(int key, string option, controlerMethod method)
        {
            var methods = new Dictionary<string, controlerMethod>();
            methods.Add(option, method);
            options.Add(key, methods);
        }

        public Dictionary<int, Dictionary<string, controlerMethod>> GetOptions()
        {
            return options;
        }

        public void ShowOptions()
        {
            foreach (var option in options)
            {
                foreach (var method in option.Value)
                {
                    Console.WriteLine($"{option.Key}.{method.Key} ");
                }
            }
        }

        public int GetSelectedOption()
        {
            return selectedOption;
        }

        public void SelectOption(int option)
        {
            selectedOption = option;

            InvokeOptionMethod(selectedOption);
        }
    }
}