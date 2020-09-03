using SOLID_DYEORDER.DyeOrderComponents;
using SOLID_DYEORDER.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.AvailableMachines
{
    public class Machine
    {
        private readonly int _portsNumber;
        private readonly Dictionary<int, Port> _ports;

        public Machine(string machineName, int portNumber, List<string> colors, Port configuredPort)
        {
            MachineName = machineName;
            _portsNumber = portNumber;
            SupportedColors = colors;
            MaxCapacity = configuredPort.maximumLoad * _portsNumber;
            AddPort(_portsNumber, configuredPort);
        }

        public string MachineName { get; set; }
        public int MaxCapacity { get; set; }
        public List<string> SupportedColors { get; }

        public void PrintPorts()
        {
            foreach (var item in GetPorts())
            {
                ConsoleBuffer.PrintOuput($"{item.Key}.Puerto {item.Key} Min: {item.Value.minimunLoad} Max: {item.Value.maximumLoad}");
            }
        }

        public Dictionary<int, Port> GetPorts()
        {
            return _ports;
        }

        public Port GetPort(int port)
        {
            if (_ports.ContainsKey(port))
            {
                return _ports[port];
            }
            return null;
        }

        public void AddPort(int limit, Port port)
        {
            _ports = new Dictionary<int, Port>();
            for (int portKey = 1; portKey <= limit; portKey++)
            {
                _ports.Add(portKey, port);
            }
        }
    }
}