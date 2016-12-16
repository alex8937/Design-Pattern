namespace Compound_Pattern
{
    using System.Collections.Generic;

    /// <summary>
    /// The flock.
    /// </summary>
    public class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            this.quackers.Add(quacker);
        }

        public void Quack()
        {
            IEnumerator<IQuackable> iterator = this.quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.Quack();
            }
        }

    }
}