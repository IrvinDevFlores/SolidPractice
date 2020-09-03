using SOLID_DYEORDER.DyeOrderComponents;
using SOLID_DYEORDER.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.AvailableMachines
{
    public class MachinesDataContext
    {
        public Dictionary<int, Machine> machines;

        public MachinesDataContext()
        {
            machines = new Dictionary<int, Machine>()
            {
                { 1, new Machine("Gaston 38" , 2 , new List<string> () {"309","362","941","511"}, new Port( 400 , 450 ))},
                {2, new Machine("Gaston 278" , 6 , new List<string> () {"309","362"},new Port(minLoad : 450 , maxLoad : 550 )) },
                {3,new Machine("Eco 3" , 3 , new List<string> () {"RQW", "WTH", "BFF"},new Port(minLoad : 275 , maxLoad : 350 ))  }
            };
        }

        public void FillPort(int port, int machine, Sku sku)
        {
            int poundsOfCloth = GetMachine(machine)?.GetPort(port)?.PoundsClothToProduce ?? 0;
            int avaibleCloth = 0;
            int maxLoadInPort = GetMachine(machine).GetPort(port).maximumLoad;
            int minLoadInPort = GetMachine(machine).GetPort(port).minimunLoad;

            do
            {
                if (poundsOfCloth == maxLoadInPort)
                {
                    Console.WriteLine("El puerto esta lleno");
                    return;
                }
                if (!(minLoadInPort >= poundsOfCloth && poundsOfCloth <= maxLoadInPort))
                {
                    Console.WriteLine("El valor no esta en los rangos establecidos");
                    return;
                }
                avaibleCloth = maxLoadInPort - poundsOfCloth;
                Console.WriteLine($"Informacion del puerto {port}: \n Cantidad actual de tela (lb): {poundsOfCloth} " +
                                    $"\n Cantidad disponible (lb):{avaibleCloth} \n Capacidad maxima: {maxLoadInPort} \n");

                ConsoleBuffer.PrintOuput("Ingrese el codigo del sku: ");
                sku.Id = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());

                ConsoleBuffer.PrintOuput("Ingrese la cantidad de libras");
                sku.Pounds = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());
                GetMachine(machine).GetPort(port).PoundsClothToProduce = sku.Pounds;
                poundsOfCloth = GetMachine(machine).GetPort(port).PoundsClothToProduce;
            } while (true);
        }

        public string GetMachineName(int key)
        {
            return machines[key].MachineName;
        }

        public Machine GetMachine(int key)
        {
            return GetMachines()[key];
        }

        public Port GetPort(int port)
        {
            return GetMachine(port).ports[port];
        }

        public List<string> GetSupportedColors(int machine)
        {
            return GetMachines()[machine].SupportedColors;
        }

        public void ShowColorsMachine(int machine)
        {
            int cont = 1;
            foreach (var color in GetSupportedColors(machine))
            {
                Console.WriteLine($"{cont++} {color}");
            }
        }

        public string GetColorInMachine(int machine, int color)
        {
            return machines[machine].SupportedColors[color];
        }

        public void ShowMachines()
        {
            foreach (var machine in machines)
            {
                Console.WriteLine($"{machine.Key}. {machine.Value.MachineName}");
            }
        }

        public Dictionary<int, Machine> GetMachines()
        {
            return machines;
        }

        public void AddMachine(int key, Machine machine)
        {
            machines.Add(key, machine);
        }

        public void RemoveMachine(int key)
        {
            machines.Remove(key);
        }
    }
}