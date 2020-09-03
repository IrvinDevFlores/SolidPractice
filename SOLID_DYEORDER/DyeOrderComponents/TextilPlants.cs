using SOLID_DYEORDER.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DYEORDER.DyeOrderComponents
{
    public class TextilPlants
    {
        public Dictionary<int, Plant> plants;

        public TextilPlants()
        {
            plants = new Dictionary<int, Plant>() {
                {1, new Plant("JK") },
                {2, new Plant("JV") },
                {3, new Plant("DV") }
            };
        }

        public void ShowPlants()
        {
            foreach (var item in GetPlants())
            {
                ConsoleBuffer.PrintOuput($"{item.Key}.  {item.Value.Name}");
            }
        }

        public string GetPlantName(int plant)
        {
            return plants[plant].Name;
        }


        public Dictionary<int, Plant> GetPlants()
        {
            return plants;
        }
    }
}
