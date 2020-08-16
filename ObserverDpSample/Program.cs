using ObserverDpSample.Concrete_Observer;
using ObserverDpSample.Subject;
using System;

namespace ObserverDpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting position of subsucribers(State)
            Position playerPosition = new Position() { X = 5, Y = 10, Z = 20 };
            Position refreePosition = new Position() { X = 2, Y = 7, Z = 9 };

            //setting position of Publisher(State)
            Position footballPosition = new Position() { X = 10, Y = 2, Z = 12 };

            //publisher object
            Football football = new Football();

            //preparing subscribers objects...
            Refree refree = new Refree(football, refreePosition);
            Player player = new Player(football, playerPosition);

            //subscribing player and refree to the football
            football.AttachObserver(player);
            football.AttachObserver(refree);

            ////changing the state of the publisher
            football.Position = footballPosition;

            ////notify subscribers(player, refree,...)
            football.Notify();


            //deatching refree (unsubscribing)
            football.DetachObserver(refree);

            ///notfiy subscriber(player)=>the only one subscribed
            football.Notify();


            Console.WriteLine("American Football  Publisher \n");

            Ball americanFootball = new AmericanFootball();

            //Old Subucribers
            player = new Player(americanFootball, playerPosition);
            refree = new Refree(americanFootball, refreePosition);

            americanFootball.AttachObserver(player);
            americanFootball.AttachObserver(refree);

            americanFootball.Position = new Position()
            {
                X = 45,
                Y = 78,
                Z = 71
            };

            americanFootball.Notify();

        }
    }
}
