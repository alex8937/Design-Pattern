namespace Decorator_Pattern
{
    /// <summary>
    /// The espresso.
    /// </summary>
    public class Espresso : SizeBeverage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Espresso"/> class.
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        public Espresso(SizeType size)
        {
            this.Size = size;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        public override SizeType Size { get; }

        /// <summary>
        /// The cost.
        /// </summary>
        public override decimal Cost
        {
            get
            {
                switch (this.Size)
                {
                    case SizeType.Tall:
                        return 1.99m;
                    case SizeType.Grande:
                        return 2.99m;
                    default:
                        return 3.99m;
                }
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public override string Description => this.SizeToString(this.Size) + "Espresso Coffee";

    }
}