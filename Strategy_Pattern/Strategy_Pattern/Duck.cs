using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// The duck.
    /// </summary>
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;

        private IQuackBehavior quackBehavior;


        public void SetFly(IFlyBehavior flyer)
        {
            this.flyBehavior = flyer;
        }
        public void SetQuack(IQuackBehavior quacker)
        {
            this.quackBehavior = quacker;
        }

        public void DoFly()
        {
            this.flyBehavior.Fly();
        }

        public void DoQuack()
        {
            this.quackBehavior.Quack();
        }
    }

    public sealed class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            this.SetFly(new FlyWithWings());
            this.SetQuack(new NormalQuack());
        }
    }

    public sealed class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.SetFly(new FlyNoWay());
            this.SetQuack(new Squeak());
        }
    }

    public sealed class ToastDuck : Duck
    {
        public ToastDuck()
        {
            this.SetFly(new FlyNoWay());
            this.SetQuack(new MuteQuack());
        }
    }
}
