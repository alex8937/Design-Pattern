namespace Compound_Pattern
{
    /// <summary>
    /// The goose adapter.
    /// </summary>
    public class GooseAdapter : IQuackable
    {
        private readonly Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            this.goose.Honk();
        }
    }
}