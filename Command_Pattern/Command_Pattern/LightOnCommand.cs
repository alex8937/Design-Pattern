namespace Command_Pattern
{
    public class LightOnCommand : Command
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            this.light.on();
        }

        public void Undo()
        {
            this.light.off();
        }
    }
}