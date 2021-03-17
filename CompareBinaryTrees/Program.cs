using System;
using System.Collections.Generic;
using System.IO;

namespace Program 
{
  public class Tree<T> {
    public Tree (T data, Tree<T> leftNode = null, Tree<T> rightNode = null) {
      this.Left = leftNode;
      this.Right = rightNode;
      this.Data = data;
    }

    public Tree<T> Left;
    public Tree<T> Right;
    public T Data;
  }

  class Program {
      static bool compareTrees(Tree<int> tree1, Tree<int> tree2) 
      {
        System.Console.WriteLine($"comparando {tree1?.Data} {tree2?.Data}");

        if(tree1 == null || tree2 == null)
          return tree1 == tree2;

        return 
          tree1.Data == tree2.Data && 
          compareTrees(tree1.Left, tree2.Left) && 
          compareTrees(tree1.Right, tree2.Right);
        
      }

      static void Main(string[] args)
      {
        Tree<int> tree01 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
        Tree<int> tree02 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
        Tree<int> tree03 = new Tree<int>(1, new Tree<int>(2, new Tree<int>(4), new Tree<int>(5)), new Tree<int>(3));
        Tree<int> tree04 = new Tree<int>(1, new Tree<int>(2, new Tree<int>(4), new Tree<int>(6)), new Tree<int>(3));
        
        var result = compareTrees(tree03, tree04);
        Console.WriteLine(result);
      }
  }
}
