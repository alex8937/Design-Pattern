namespace Decorator_Pattern
{
    /// <summary>
    /// The size beverage.
    /// </summary>
    public abstract class SizeBeverage : Beverage, ISize
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        public abstract SizeType Size { get; }

        /// <summary>
        /// The size to string.
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string SizeToString(SizeType size)
        {
            switch (size)
            {
                case SizeType.Tall:
                    return "Tall-size ";
                case SizeType.Grande:
                    return "Grande-size ";
                default:
                    return "Venti-size ";
            }
        }
    }
}