using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDpSample.Product
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        //public Car(string make, string model, string color, int doors)
        //{
        //    Make = make;
        //    Model = model;
        //    Color = color;
        //    NumberOfDoors = doors;
        //}
        public override string ToString()
        {
            return $"Make is: {Make} , model is: {Model} , Color: {Color} , #doors: {NumberOfDoors}";
        }
    }
}
