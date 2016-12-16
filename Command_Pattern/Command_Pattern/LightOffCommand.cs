namespace Command_Pattern
{
    public class LightOffCommand : Command
    {
        private Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            this.light.off();
        }

        public void Undo()
        {
            this.light.on();
        }
    }
}