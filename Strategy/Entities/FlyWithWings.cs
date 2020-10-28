using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entities
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I fly using wings");
        }
    }
}
