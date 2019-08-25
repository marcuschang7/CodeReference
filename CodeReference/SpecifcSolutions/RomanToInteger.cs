using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class RomanToInteger
    {
        public static int ConvertLetterToNumber(char letter)
        {
            switch (letter)
            {
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'I':
                    {
                        return 1;
                    }

                default:
                    {
                        throw new ArgumentException("Invalid character");
                    }



            }

        }
        public static int RomanToInt(string s)
        {
            s = s.ToUpper();
            int result = 0;
            foreach (var item in s)
            {
                result += ConvertLetterToNumber(item); // Get value and add to results
            }
            if (s.Contains("IV") || s.Contains("IX")) // Needed for higher numbers
                result -= 2;

            if (s.Contains("XL") || s.Contains("XC")) // Needed for higher numbers
                result -= 20;

            if (s.Contains("CD") || s.Contains("CM")) // Needed for higher numbers
            {
                result -= 200;
            }
            return result;

        }
        static void Main(string[] args)
        {
            string str = "LVIII";
           var test= RomanToInt(str);
            Console.WriteLine("{0} converted to Roman Numerals is {1} ", str, test);
            Console.ReadKey();
        }
    }
}
