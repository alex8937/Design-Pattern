namespace Iterator_Pattern
{
    public class ArrayClassIterator : Iterator
    {
        private int?[] store;

        private int position;

        public ArrayClassIterator(int?[] store)
        {
            this.store = store;
            this.position = 0;
        }
        public bool HasNext()
        {
            return this.position < this.store.Length && this.store[this.position] != null;
        }

        public object GetNext()
        {
            return this.store[this.position++];
        }
    }
}