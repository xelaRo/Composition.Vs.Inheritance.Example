namespace Composition.Vs.Inheritance
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void Start()
        {
            Console.WriteLine("Starting the car...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }
    }
}
