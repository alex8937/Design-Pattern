namespace Command_Pattern
{
    using System;

    public class Light
    {
        private string name;

        public Light(string name)
        {
            this.name = name;
        }
        public void on()
        {
            Console.WriteLine("The " + this.name + " light is on");
        }

        public void off()
        {
            Console.WriteLine("The " + this.name + " light is off");
        }
    }
}