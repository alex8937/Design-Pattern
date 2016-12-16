namespace Strategy_Pattern
{
    /// <summary>
    /// The FlyBehavior interface.
    /// </summary>
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }
}
