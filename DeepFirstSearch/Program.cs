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
      static bool searchInTree(Tree<int> tree, int targetNumber) 
      {
        System.Console.WriteLine($"buscando {tree?.Data.ToString() ?? "null" } == {targetNumber}");
        if(tree == null)
            return false;
        return tree.Data == targetNumber || 
          searchInTree(tree.Left, targetNumber) || 
          searchInTree(tree.Right, targetNumber);
      }

      static void Main(string[] args)
      {
        Tree<int> tree01 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
        Tree<int> tree02 = new Tree<int>(1, new Tree<int>(2), new Tree<int>(3));
        Tree<int> tree03 = new Tree<int>(1, new Tree<int>(2, new Tree<int>(4), new Tree<int>(5)), new Tree<int>(3));
        Tree<int> tree04 = new Tree<int>(0, new Tree<int>(2, new Tree<int>(4), new Tree<int>(5)), new Tree<int>(3));
        
        var result = searchInTree(tree03, 40);
        Console.WriteLine(result);

        result = searchInTree(tree03, 3);
        Console.WriteLine(result);
      }
  }
}
