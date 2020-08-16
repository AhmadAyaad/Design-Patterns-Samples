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
        public Ball ball;
        public Player(Ball ball, Position position)
        {
            this.ball = ball;
            Position = position;
        }

        public override void Update()
        {
            Position = ball.Position;
            Console.WriteLine($"Player moved to {Position}");
        }
    }
}
