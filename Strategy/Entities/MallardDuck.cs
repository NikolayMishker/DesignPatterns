using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entities
{
    public class MallardDuck : Duck
    {
        public MallardDuck(string Name)
        {
            name = Name;
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();

        }

        public override void DisplayName()
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}
