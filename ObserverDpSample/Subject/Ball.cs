using ObserverDpSample.observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDpSample.Subject
{
    abstract class Ball
    {
        List<Observer> observers;
        public Ball()
        {
            observers = new List<Observer>();
        }
        public void AttachObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
