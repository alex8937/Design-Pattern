namespace Iterator_Pattern
{
    using System.Collections;
    using System.Collections.Generic;

    public class ListClass : IEnumerable<int?>
    {
        private List<int?> nums;

        public ListClass(int len)
        {
            this.nums = new List<int?>(len);
            for (int i = 0; i < len / 2; ++i)
            {
                this.nums.Add(i);
            }
        }


        public IEnumerator<int?> CreateIterator => nums.GetEnumerator();

        public IEnumerator<int?> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}