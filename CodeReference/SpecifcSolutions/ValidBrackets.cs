using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class ValidBrackets
    {
        public static bool IsValid(string s)
        {
            // Arrays should contain paired parentheses in the same order:
            char[] OpenParentheses = { '(', '[', '{' };
            char[] CloseParentheses = { ')', ']', '}' };
            // Indices of the currently open parentheses:
            Stack<int> parentheses = new Stack<int>(); //Create stack

            foreach (char chr in s)  
            {
                int index;
                var test = index = Array.IndexOf(OpenParentheses, chr); //Array.IndexOf(ArrayIndexToSearch, ValueToLookup)

                if ((index = Array.IndexOf(OpenParentheses, chr)) != -1)  // Check if the 'chr' is an open parenthesis, and get its index:
                {
                    parentheses.Push(index);  // Add index to stack
                }

                else if ((index = Array.IndexOf(CloseParentheses, chr)) != -1)  // Check if the 'chr' is a close parenthesis, and get its index:
                {
                    if (parentheses.Count == 0 || parentheses.Pop() != index) // Return 'false' if the stack is empty or if the currently open parenthesis is not paired with the 'chr':
                        return false;
                }
            }
            return parentheses.Count == 0;
        }
        static void Main(string[] args)
        {
            string str = "()[)";
            var test = IsValid(str);
            Console.WriteLine("'{0}' Brackets properly closed {1} = ", str, test);
            Console.ReadKey();
        }
    }
}

