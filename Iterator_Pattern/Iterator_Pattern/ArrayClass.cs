namespace Iterator_Pattern
{
    using System;

    public class ArrayClass
    {
        private int?[] nums;

        public ArrayClass(int len)
        {
            this.nums = new int?[len];
            for (int i = 0; i < nums.Length / 2; ++i)
            {
                this.nums[i] = i;
            }

        }

        public Iterator CreateIterator => new ArrayClassIterator(this.nums);

    }
}