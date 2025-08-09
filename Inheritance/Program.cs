namespace Inheritance
{

    //Inheritance means creating a new class
    //that gets features from an existing class.
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Year = 2015;
            car.Model = "Aqua";
            car.NumberOfWheels = 4;
            car.NumberOfDoors = 4;
            car.CC = 1500;
            car.Start();
            car.Stop();
        }
    }
}
