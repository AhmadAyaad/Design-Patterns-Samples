using BuilderDpSample.Abstract_Builder;
using BuilderDpSample.Concrete_Builder;
using BuilderDpSample.Director;
using System;

namespace BuilderDpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder carBuilder = new SubaruCarBuilder();
            SportsCarBuilderDirector sportsCarBuilderDirector = new SportsCarBuilderDirector(carBuilder);
            sportsCarBuilderDirector.ConstructCar();
            var car = sportsCarBuilderDirector.GetCar();
            Console.WriteLine("Subaru Car:");
            Console.WriteLine(car);


            carBuilder = new EvoCarBuilder();
            sportsCarBuilderDirector = new SportsCarBuilderDirector(carBuilder);
            sportsCarBuilderDirector.ConstructCar();
            Console.WriteLine("EVO Car:");
            Console.WriteLine(sportsCarBuilderDirector.GetCar());

        }
    }
}
