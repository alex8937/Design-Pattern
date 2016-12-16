namespace Decorator_Pattern
{
    /// <summary>
    /// The house blend.
    /// </summary>
    public class HouseBlend : SizeBeverage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HouseBlend"/> class. 
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        public HouseBlend(SizeType size)
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
                        return 1.59m;
                    case SizeType.Grande:
                        return 2.59m;
                    default:
                        return 3.59m;
                }
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public override string Description => this.SizeToString(this.Size) + "House Blend Coffee";

    }

}