using System;
using System.Collections.Generic;

namespace LongestPath
{
    class Tree<T> {
        public Tree(T value, Tree<T> left = null, Tree<T> right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        public T Value { get; set; }
        public Tree<T> Left { get; set; }
        public Tree<T> Right { get; set; }  
    }

    class Program
    {

        public static int FindLongestPath<T>(Tree<T> tree, int pathSize = 0, Dictionary<T, bool> alreadySeen = null) 
        {
            if(tree == null)
                return pathSize;

            if(alreadySeen == null) alreadySeen = new Dictionary<T, bool>();

            if(alreadySeen.ContainsKey(tree.Value) == true) 
                return pathSize;

            alreadySeen.Add(tree.Value, true);
            pathSize++;
            
            int leftPathSize = FindLongestPath<T>(tree.Left, pathSize, alreadySeen);
            int rightPathSize = FindLongestPath<T>(tree.Right, pathSize, alreadySeen);

            return leftPathSize > rightPathSize ? leftPathSize : rightPathSize;            
        }
        
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(1, 
                new Tree<int>(1, 
                    new Tree<int>(6,
                        new Tree<int>(5),
                        new Tree<int>(6)
                    ), 
                    new Tree<int>(2, 
                        new Tree<int>(2),
                        new Tree<int>(5)
                    )
                ), 
                new Tree<int>(3,
                    new Tree<int>(5), 
                    new Tree<int>(3,
                        new Tree<int>(2),
                        new Tree<int>(1)
                    )
                )
            );

            int longestpath = FindLongestPath(tree);
            Console.WriteLine($"Longest Path = {longestpath}");
        }
    }
}
