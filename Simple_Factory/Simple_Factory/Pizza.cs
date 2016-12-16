namespace Simple_Factory
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
        public void Prepare()
        {
            Console.WriteLine("Prepare " + this.Name);
        }

        /// <summary>
        /// The bake.
        /// </summary>
        public void Bake()
        {
            Console.WriteLine("Bake " + this.Name);
        }

        /// <summary>
        /// The cut.
        /// </summary>
        public void Cut()
        {
            Console.WriteLine("Cut " + this.Name);
        }

        /// <summary>
        /// The box.
        /// </summary>
        public void Box()
        {
            Console.WriteLine("Box " + this.Name);
        }
    }
}