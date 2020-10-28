using Strategy.Interfaces;
using System;

namespace Strategy.Entities
{
    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I squeak");
        }
    }
}
