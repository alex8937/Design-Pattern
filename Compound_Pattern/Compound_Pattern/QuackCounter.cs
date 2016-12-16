namespace Compound_Pattern
{
    /// <summary>
    /// The quack counter.
    /// </summary>
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable duck;

        public static int NumberQuacker { get; set; }

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            NumberQuacker++;
            this.duck.Quack();
        }
    }
}