using System;
using System.Collections;

namespace Custom_list_and_CustomStack_WorkShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList myList = new CustomList();

            //myList.RemoveAt();

            myList.Add(10);
            myList.Add(20);
            // myList.Add(30);
            // myList.Add(40);
            // myList.Add(50);
            // myList.RemoveAt(1);
            //// myList.RemoveAt(0);

            myList.Insert(0, 100);
            myList.Insert(1, 200);
            myList.Insert(4, 300);
            //myList.Insert(6, 300);

            Console.WriteLine(myList.Contains(2200));

            // myList.Add(4);

            myList.Swap(0, 1);

            //Stack<int> nums = new Stack<int>(); 
            CustomStack myStack = new CustomStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push(50);

            myStack.MySelect(e => e * 10);
            myStack.ForEach(e => Console.WriteLine(e));

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}
