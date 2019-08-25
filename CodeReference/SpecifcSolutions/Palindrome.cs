using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class Palindrome
    {
        // integer
        public static bool IsPalindrome(int x)
        {
            bool isValid = false;
            int palindrome = x;
            //int palindromeAbs = Math.Abs(x);
            int prev_rev_num = 0; // Used to verify overflow
            int palindromeAbs = x < 0 ? x * -1 : x; // if negative multiply by -1 else just use passed number
            palindromeAbs = x > int.MaxValue ? 0 : palindromeAbs;
            int reverse = 0;

            while (palindromeAbs > 0) // Get Absolute value to handle negative numbers
            {
                // To reverse the number, every time you enter the loop, you should add the last remainder you've found to the right of x, 
                // which is effectively equivalent to multiplying everything by 10 and adding remainder.To reverse the number, every time you enter the loop, 
                // you should add the last remainder you've found to the right of x, which is effectively equivalent to multiplying everything by 10 and adding remainder.
                int remainder = palindromeAbs % 10; // Get remainder after dividing by 10 this gets last digit example 1223/10= 122.3 3=remainder
                reverse = (reverse * 10) + (remainder); // Here we build up the reverse multiplying by 10 and adding remainder

                if ((reverse - remainder) / 10 != prev_rev_num) // Check for overflow (reverse - remainder) / 10; Should equal prev_rev_num)
                {
                    var test = (reverse - remainder) / 10;
                    Console.WriteLine("WARNING OVERFLOWED!!!");
                    return false;
                }
                prev_rev_num = reverse;
                palindromeAbs = palindromeAbs / 10; // Then we divide palindrome by 10 decimal removed example 12/10=1.2 but decimal removed equals 1 this shaves of the last digit  

            }

            // Include sign if negative
            //if (x < 0) // This should be commented out if its for a Palindrome. Don't comment if normal reverse
            //{
            //    reverse = reverse * -1;
            //}

            if (x == reverse)
            {
                isValid = true;
            }
            return isValid;

        }
        static void Main(string[] args)
        {
            int num = -121;
            Console.Write("{0} is Palindrome={1}", num, IsPalindrome(num));
            Console.ReadKey();
        }
    }
}
