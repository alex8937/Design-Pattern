namespace Strategy_Pattern
{
    /// <summary>
    /// The program.
    /// </summary>
    static class Program
    {
        static void Main()
        {
            Duck redhead = new RedheadDuck();
            redhead.DoFly();
            redhead.DoQuack();
            ToastDuck deadduck = new ToastDuck();
            deadduck.DoFly();
            deadduck.DoQuack();
            deadduck.SetFly(new FlyWithRocket());
            deadduck.DoFly();
        }
    }
}
