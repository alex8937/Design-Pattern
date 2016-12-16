namespace Singleton_Pattern
{
    public sealed class LazySingleton
    //http://csharpindepth.com/articles/general/singleton.aspx#cctor Approach 4
    {
        private static readonly LazySingleton LazySingletonIntstance = new LazySingleton();

        static LazySingleton()
        {
        }

        private LazySingleton()
        {
        }

        private static LazySingleton getInstance => LazySingletonIntstance;
    }
}