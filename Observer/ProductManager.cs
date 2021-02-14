using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ProductManager
    {
        List<Observer> observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product Price Changed !");
            Notify();
        }
        public void Atach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        private void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
