using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    class CustomArr<T> : IEnumerable
    {
        private T[] arr;
        private static int InitialCapacity = 4;
        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public CustomArr()
        {
            this.arr = new T[InitialCapacity];
            this.count = 0;
        }

        public void Add(T item)
        {
            if (count == arr.Length)
            {
                Resize();
            }
            arr[this.count] = item;
            this.count++;
        }

        private void Resize()
        {
            T[] copy = new T[arr.Length * 2];
            Array.Copy(arr, copy, arr.Length);
            arr = copy;          
        }

        private void Shift(int index)
        {
            for (int i = index; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public void Insert(int index, T item)
        {
            if(count == arr.Length)
            {
                Resize();
            }

            for (int i = this.count; i >= index; i--)
            {
                arr[i] = arr[i - 1];
            }
        }

        public void Print()
        {
            foreach (var item in this.arr)
            {
                Console.WriteLine();
            }
        }

    }
}
