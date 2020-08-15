using ObserverDpSample.observer;
using ObserverDpSample.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDpSample.Concrete_Observer
{
    class Refree : Observer
    {
        Position position;
        Football football;
        public Refree(Football football, Position position)
        {
            this.football = football;
            this.position = position;
        }

        public override void Update()
        {
            position = football.Position;
            Console.WriteLine($"Refree moved to: {position}");
        }
    }
}
