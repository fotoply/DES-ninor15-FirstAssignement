using System;
using System.Text;

namespace DES_ninor15.Task6
{
    public class Task6
    {
        public void TestString(string str)
        {
            Console.WriteLine("Initial string: " + str);
            Console.WriteLine("Reversed string: " + ReverseString(str));
            Console.WriteLine("Is a palindrome? " + IsPalindrome(str));
        }

        public static string ReverseString(string str)
        {
            Stack stack = new Stack();
            foreach (var character in str.ToCharArray())
            {
                stack.Push(character);
            }
            StringBuilder newStr = new StringBuilder();
            while (!stack.IsEmpty)
            {
                newStr.Append(stack.Pop());
            }
            return newStr.ToString();
        }

        public static bool IsPalindrome(string str)
        {
            return str.Equals(ReverseString(str)); // Can be done for cheaper with a for loop.
        }

        public void Main()
        {
            string test = "test string";
            Console.WriteLine("Original: " + test);
            test = ReverseString(test);
            Console.WriteLine("Reversed: " + test);

            test = "mellem";
            Console.WriteLine(test + " : is palindrome : " + IsPalindrome(test));
            test = "abcdef";
            Console.WriteLine(test + " : is palindrome : " + IsPalindrome(test));
        }
    }
}