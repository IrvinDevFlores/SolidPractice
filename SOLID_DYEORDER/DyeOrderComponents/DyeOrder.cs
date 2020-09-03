using SOLID_DYEORDER.AvailableMachines;
using SOLID_DYEORDER.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.DyeOrderComponents
{
    public class DyeOrder
    {
        public int Id { get; set; }
        public string TypeMachine { get; set; }
        public string Color { get; set; }
        public string Plant { get; set; }

        public List<Sku> SkuDetails;
        private Sku _sku;

        public DyeOrder()
        {
        }

        public void CreateDyeOrder()
        {
            ConsoleBuffer.PrintOuput("* Generando reporte *");
            ConsoleBuffer.PrintOuput("Enter number id: ");
            Id = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());

            ConsoleBuffer.PrintOuput("Enter type machine: ");
            MachinesDataContext data = new MachinesDataContext();
            data.ShowMachines();
            int machine = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());
            TypeMachine = data.GetMachineName(machine);

            ConsoleBuffer.PrintOuput("Enter dye-order's color: ");
            data.ShowColorsMachine(machine);
            int color = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine()) - 1;
            Color = data.GetColorInMachine(machine, color);

            ConsoleBuffer.PrintOuput("Enter textil plant: ");
            TextilPlants plants = new TextilPlants();
            plants.ShowPlants();
            int plant = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());
            Plant = plants.GetPlantName(plant);

            ConsoleBuffer.PrintOuput($"Llenando maquina (Puede moverse entre puertos) \n Usted eligio ==> {TypeMachine} " +
                $"\n Posee ==> {new MachinesDataContext().GetMachines()[machine]._portsNumber  } puertos. \n Elija el puerto: ");

            data.GetMachine(machine).PrintPorts();
            int port = ConsoleBuffer.ProcessGeneralInput(Console.ReadLine());
            data.FillPort(port, machine, new Sku());

            //
        }
    }
}