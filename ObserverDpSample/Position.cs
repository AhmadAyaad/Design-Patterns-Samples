using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDpSample
{
    class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $"X: {X} , Y: {Y} , Z:{Z}";
        }
    }
}
