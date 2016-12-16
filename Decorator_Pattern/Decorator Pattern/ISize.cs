namespace Decorator_Pattern
{
    /// <summary>
    /// The Size interface.
    /// </summary>
    public interface ISize
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        SizeType Size { get; }

        /// <summary>
        /// The size to string.
        /// </summary>
        /// <param name="size">
        /// The size.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string SizeToString(SizeType size);
    }
}