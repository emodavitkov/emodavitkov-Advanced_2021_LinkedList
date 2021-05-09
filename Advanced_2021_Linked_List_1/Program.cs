using System;

namespace LinkedList
{
   class Program
    {
        static void Main(string[] args)
          {
            Node node = new Node(1);
            //node.Next.Next.Next.Next = new Node(5);

            
            SoftuniLinkedList linkedList = new SoftuniLinkedList();

            Console.WriteLine("Remove empty head: " + linkedList.RemoveHead());

            for (int i = 0; i < 10; i++)
            {
                linkedList.AddHead(new Node(i));
            }

            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast(new Node(i));
            }
            //linkedList.AddHead(new Node(1));
            //linkedList.AddHead(new Node(2));
            //linkedList.AddHead(new Node(3));
            //linkedList.AddHead(new Node(4));

            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);
            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);
            Console.WriteLine("Remove head: " + linkedList.RemoveHead().Value);

            Console.WriteLine("Remove tail: " + linkedList.RemoveTail().Value);
            Console.WriteLine("Remove tail: " + linkedList.RemoveTail().Value);
            Console.WriteLine("Remove tail: " + linkedList.RemoveTail().Value);

            //var currentNode = linkedList.Head;

            var currentNode = linkedList.Tail;

            //first build
            //    Node head = new Node(1);
            //    Node node2 = new Node(2);
            //    Node node3 = new Node(3);
            //    Node node4 = new Node(4);

            //    head.Next = node2;
            //    node2.Next = node3;
            //    node3.Next = node4;

            //    Node currentNode = head;


            //while (currentNode !=null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}


            Console.WriteLine("Foreach from head:");
            linkedList.ForeachFromHead((node) =>
                {
                Console.WriteLine($"From action: {node.Value}");
                });

            Console.WriteLine("Foreach from tail:");
            linkedList.ForeachFromTail((node) =>
            {
                Console.WriteLine($"From action: {node.Value}");
            });


            int[] linkedListAsArray = linkedList.ToArray();
        }
    }
}
