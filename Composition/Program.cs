namespace Composition
{
    //Composition means building a class by combining(including)
    //objects of other classes instead of inheriting from them.
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            car.StartCar();
        }
    }
}
