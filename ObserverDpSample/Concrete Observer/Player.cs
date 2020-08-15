using ObserverDpSample.observer;
using ObserverDpSample.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDpSample.Concrete_Observer
{
    class Player : Observer
    {
        public Position Position;
        public Football Football;
        public Player(Football football, Position position)
        {
            Football = football;
            Position = position;
        }

        public override void Update()
        {
            Position = Football.Position;
            Console.WriteLine($"Player moved to {Position}");
        }
    }
}
