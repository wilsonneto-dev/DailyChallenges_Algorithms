using System;
using System.Collections.Generic;
using System.IO;

namespace Program {
  class Solution {
    static bool IsPalindrome(String text)
    {
      char[] chars = text.ToCharArray();
      int firstPointerPosition = 0;
      int lastPointerPosition = chars.Length -1;

      while(firstPointerPosition < lastPointerPosition)
      {
        if(chars[firstPointerPosition] != chars[lastPointerPosition])
          return false;
        firstPointerPosition++;
        lastPointerPosition--;
      }
      
      return true;
    }

    static void Main() {
      Console.WriteLine("Entre com a string para ser testada se é palindrome");
      string textToTest = Console.ReadLine();

      bool result = IsPalindrome(textToTest);

      Console.WriteLine(result);
    }
  }
} 