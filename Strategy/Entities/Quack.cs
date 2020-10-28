using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entities
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("I quack");
        }
    }
}

