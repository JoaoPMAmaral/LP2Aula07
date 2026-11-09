using System;
using System.Collections.Generic;


namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ISet<IObserver<AbstractStringSubject>> observers;

        private string item;

        public string Item
        {
            get => item;
            protected set
            {
                item = value;
                foreach(var obs in observers) //em vez de var pode ser "IObserver<AbstractStringSubject>"
                {
                    obs.Update(this);
                }
            }
        }

        public AbstractStringSubject()
        {
            observers = new HashSet<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }
    }
}