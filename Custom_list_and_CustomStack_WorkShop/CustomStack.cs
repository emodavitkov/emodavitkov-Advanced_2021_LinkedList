using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_list_and_CustomStack_WorkShop
{
    public class CustomStack
    {
        private int[] array;
        private const int InitialCapacity=4;
        public CustomStack()
        {
            this.array = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (this.Count==this.array.Length)
            {
                this.Resize();
            }
            this.array[this.Count] = element;
            this.Count++;

        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];
            Array.Copy(this.array, copy, this.Count);
            this.array = copy;
        }

        public int Pop()
        {
            this.Validate();
            
            int element = this.array[this.Count-1];
            this.array[this.Count - 1] = default; 
            this.Count--;

            if (this.Count == this.array.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

       

        public int Peek()
        {
            this.Validate();

            return this.array[this.Count - 1];

        }

        public void ForEach(Action<int> action)
        {
            foreach (var element in this.array)
            {
                action(element);
            }
        }

        public void MySelect(Func<int,int> func)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int element = this.array[i];
                int a = func(element);
                this.array[i] = a;
            }
        }
        private void Validate()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

        }
        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];
            Array.Copy(this.array, copy, this.Count);
            this.array = copy;
        }
    }
}
