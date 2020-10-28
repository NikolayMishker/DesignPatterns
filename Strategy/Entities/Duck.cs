using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Entities
{
    public abstract class Duck
    {
        public string name;
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void DisplayName();
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void setFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void setQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

    }
}
