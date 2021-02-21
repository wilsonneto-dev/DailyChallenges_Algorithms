using System;
using System.Collections.Generic;
using System.IO;

namespace Program 
{
  class Solution {
      static int[] simpleArraySum(int[] numbers, int target) {
        Dictionary<int, bool> numbersDictionary = new Dictionary<int, bool>();
        foreach (int number in numbers)
        {
          int neededNumber = target - number;
          if(numbersDictionary.ContainsKey(neededNumber))
            return new int[] { neededNumber, number };
          else
            numbersDictionary.Add(number, true);
        }
        return null;
      }

      static void Main(string[] args) {

          Console.WriteLine("Enter array values");
          int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

          Console.WriteLine("Enter the target number");
          int target = Convert.ToInt32(Console.ReadLine());

          var result = simpleArraySum(numbers, target);

          Console.WriteLine(String.Join(",",result));
      }
  }
}
