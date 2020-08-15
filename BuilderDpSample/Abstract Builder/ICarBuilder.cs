using BuilderDpSample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDpSample.Abstract_Builder
{
    interface ICarBuilder
    {
        void SetMake();
        void SetModel();
        void SetColor();
        void SetNumberOfDoors();
        Car GetResult();    
    }
}
