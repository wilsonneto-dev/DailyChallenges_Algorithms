using System;
using System.Collections.Generic;

namespace Breadth_First_Search__BFS_
{
    class Program
    {
        public class Tree<T> {
            public Tree(T data, Tree<T> left = null, Tree<T> right = null) {
                this.Data = data;
                this.Left = left;
                this.Right = right;
            }

            public T Data { get; set; }
            public Tree<T> Left { get; set; }
            public Tree<T> Right { get; set; }
        }

        private static bool breadthFirstSearch(Tree<int> tree, int targetNumber)
        {
            Queue<Tree<int>> queue = new Queue<Tree<int>>();
            queue.Enqueue(tree);

            while(queue.Count > 0) {
                var node = queue.Dequeue();

                System.Console.WriteLine($"testing ${node.Data}");

                if(node.Data == targetNumber)
                    return true;
                
                if(node.Left != null)
                    queue.Enqueue(node.Left);
                    
                if(node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing");

            Tree<int> tree01 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
            Tree<int> tree02 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
            Tree<int> tree03 = new Tree<int>(1, new Tree<int>(2, new Tree<int>(4), new Tree<int>(5)), new Tree<int>(3));
            Tree<int> tree04 = new Tree<int>(0, new Tree<int>(2, new Tree<int>(4), new Tree<int>(5)), new Tree<int>(3));

            System.Console.WriteLine($"false? ${ breadthFirstSearch(tree01, 150)}");
            System.Console.WriteLine($"true? ${ breadthFirstSearch(tree01, 3)}");
            System.Console.WriteLine($"true? ${ breadthFirstSearch(tree04, 3)}");
        }
    }
}
