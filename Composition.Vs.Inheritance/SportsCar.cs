namespace Composition.Vs.Inheritance
{
    public class SportsCar : Car
    {
        public string Color { get; set; }

        public SportsCar(string make, string model, int year, string color)
            : base(make, model, year)
        {
            Color = color;
        }

        public override void Start()
        {
            Console.WriteLine("Starting the sports car...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the sports car...");
        }

        public void OpenConvertibleRoof()
        {
            Console.WriteLine("Opening convertible roof...");
        }

        public void CloseConvertibleRoof()
        {
            Console.WriteLine("Closing convertible roof...");
        }
    }
}
