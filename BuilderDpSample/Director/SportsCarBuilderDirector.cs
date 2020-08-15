using BuilderDpSample.Abstract_Builder;
using BuilderDpSample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDpSample.Director
{
    class SportsCarBuilderDirector
    {

        ICarBuilder carBuilder;
        public SportsCarBuilderDirector(ICarBuilder builder)
        {
            carBuilder = builder;
        }

        public Car GetCar()
        {
            return carBuilder.GetResult();
        }
        public void ConstructCar()
        {
            carBuilder.SetMake();
            carBuilder.SetModel();
            carBuilder.SetColor();
            carBuilder.SetNumberOfDoors();
        }
    }
}
