using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace leumicard
{
    public delegate void CoffeeReadyEventHandler(object sender);

    class B
    {
        public event CoffeeReadyEventHandler CoffeeReady;

        public void makeCoffee()
        {
            Debug.WriteLine("B.makeCoffee");
            Thread.Sleep(1000);
            OnCoffeeReady(); // start raise event
            
        }

        protected virtual void OnCoffeeReady()
        {
            CoffeeReady?.Invoke(this);//Raise the event
        }
    }
}
