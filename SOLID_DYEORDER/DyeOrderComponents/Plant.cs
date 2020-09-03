namespace SOLID_DYEORDER.DyeOrderComponents
{
    public class Plant
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Plant(string name)
        {
            Name = name;
        }
    }
}