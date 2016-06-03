using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "the quick brown fox";
            string ss = "THE QUICK BROWN FOX";

            char[] charArray;
            charArray = s.ToCharArray(); // turn string to char array

            if (char.IsLower(charArray[0])) // check if the first element in the array is lower, if true, upper case it
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            for (int i = 1; i < charArray.Length; ++i) // loop through char array
            {
                if (char.IsUpper(charArray[i])) // checks if element in array is uppercase, if so, lower case it
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }

                if (charArray[i - 1] == ' ') // check for spaces
                {
                    if (char.IsLower(charArray[i])) // if the char array is lower, upper case it
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                    }
                }
            }

            Console.Write(charArray);
            Console.Read();
        }
    }
}
