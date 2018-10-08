using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leumicard
{
    class A
    {
        private B b;

        public A()
        {
            b = new B();
            b.CoffeeReady += new CoffeeReadyEventHandler(callFriend);
        }

        public void run()
        {
            Debug.WriteLine("A.run");
            b.makeCoffee();
        }

        public void callFriend(object sender)
        {
            Debug.WriteLine("A.callFriend");
        }
    }
}
