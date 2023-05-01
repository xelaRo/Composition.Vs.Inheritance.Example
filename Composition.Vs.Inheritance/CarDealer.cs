namespace Composition.Vs.Inheritance
{
    public class CarDealer
    {
        private Car _car;

        public CarDealer(Car car)
        {
            _car = car;
        }

        public void Sell()
        {
            Console.WriteLine("Selling a car...");
            _car.Start();
            _car.Stop();
        }
    }
}
