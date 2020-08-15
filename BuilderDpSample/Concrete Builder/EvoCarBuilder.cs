using BuilderDpSample.Abstract_Builder;
using BuilderDpSample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDpSample.Concrete_Builder
{
    class EvoCarBuilder : ICarBuilder
    {
        Car car;
        public EvoCarBuilder()
        {
            car = new Car();
        }
        public Car GetResult()
        {
            return car;
        }

        public void SetColor()
        {
            car.Color = "Black";
        }

        public void SetMake()
        {
            car.Make = "Mitsubishi";
        }

        public void SetModel()
        {
            car.Model = "Evolution";
        }

        public void SetNumberOfDoors()
        {
            car.NumberOfDoors = 1;
        }
    }
}
