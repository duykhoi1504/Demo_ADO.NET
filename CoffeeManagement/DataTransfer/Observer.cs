using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public static class Observer
    {
        public static List<IObserver> observers = new List<IObserver>();
        public static void Register(IObserver o)
        {
            observers.Add(o);
        }
        public static void Unregister(IObserver o)
        {
            observers.Remove(o);
        }
        public static void Notify(string key)
        {
            foreach (IObserver o in observers)
            {
                o.OnNotify(key);
            }
        }
    }
}
