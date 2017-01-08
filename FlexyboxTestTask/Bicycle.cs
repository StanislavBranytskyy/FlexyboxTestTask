
namespace FlexyboxTestTask
{
    public class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle()
        {
            MaxSpeed = 50;
            Type = "Mountain";
            Color = "White";
            Make = "Shimano";
            Year = 2015;
        }
    }
}
