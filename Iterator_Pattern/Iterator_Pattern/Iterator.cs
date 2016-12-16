namespace Iterator_Pattern
{
    public interface Iterator
    {
        bool HasNext();

        object GetNext();
    }
}