namespace Singleton_Pattern
{
    public sealed class StaticSingleton // Not thread-safe
    {
        private static readonly StaticSingleton StaticSingletonIntstance = new StaticSingleton();

        public int number;

        private StaticSingleton()
        {
            this.number = 0;
        }

        public static StaticSingleton GetInstance => StaticSingletonIntstance;
    }
}