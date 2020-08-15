using BuilderDpSample.Abstract_Builder;
using BuilderDpSample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDpSample.Concrete_Builder
{
    class SubaruCarBuilder : ICarBuilder
    {
        Car car;

        public SubaruCarBuilder()
        {
            car = new Car();
        }
        public Car GetResult()
        {
            return car;
        }

        public void SetColor()
        {
            car.Color = "Blue";
        }

        public void SetMake()
        {
            car.Make = "Subaru";
        }

        public void SetModel()
        {
            car.Model = "Impriza STI";
        }

        public void SetNumberOfDoors()
        {
            car.NumberOfDoors = 2;
        }
    }
}
 