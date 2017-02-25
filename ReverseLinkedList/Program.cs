using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodeFive = new Node(value: 5);
            var nodeFour = new Node(value: 4) { Next = nodeFive };
            var nodeThree = new Node(value: 3) { Next = nodeFour };
            var nodeTwo = new Node(value: 2) { Next = nodeThree };
            var nodeOne = new Node(value: 1) { Next = nodeTwo };
            var rootNode = new Node(value: 0) { Next = nodeOne };
            PrintLinkedList(rootNode);

            var rootNodeReversed = ReverseListRec(rootNode, previous: null);
            PrintLinkedList(rootNodeReversed);

            Console.ReadKey();
        }

        // Recursive
        static Node ReverseListRec(Node node, Node previous)
        {
            var next = node.Next;
            node.Next = previous;

            return next == null ? node : ReverseListRec(next, node);
        }

        // Iterative
        static Node ReverseListIt(Node rootNode)
        {
            Node next;
            Node prev = null;

            var node = rootNode;
            while (node != null)
            {
                next = node.Next;
                node.Next = prev;
                prev = node;

                node = next;
            }

            return prev;
        }

        static void PrintLinkedList(Node rootNode)
        {
            var node = rootNode;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
