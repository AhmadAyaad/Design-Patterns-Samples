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
        Ball ball;
        public Refree(Ball ball, Position position)
        {
            this.ball = ball;
            this.position = position;
        }

        public override void Update()
        {
            position = ball.Position;
            Console.WriteLine($"Refree moved to: {position}");
        }
    }
}
