namespace Factory_Pattern
{
    using System;

    /// <summary>
    /// The pizza.
    /// </summary>
    public abstract class Pizza
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The prepare.
        /// </summary>
        public virtual void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);
        }

        /// <summary>
        /// The bake.
        /// </summary>
        public virtual void Bake()
        {
            Console.WriteLine("Bake " + this.Name);
        }

        /// <summary>
        /// The cut.
        /// </summary>
        public virtual void Cut()
        {
            Console.WriteLine("Cut " + this.Name);
        }

        /// <summary>
        /// The box.
        /// </summary>
        public virtual void Box()
        {
            Console.WriteLine("Box " + this.Name);
        }
    }
}