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
            char[] charArray;
            char currentLetter;

            charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; ++i)
            {
                currentLetter = charArray[i];
                if(char.IsLower(currentLetter))
                {
                    charArray[i] = char.ToUpper(currentLetter);
                }
            }
            Console.Write(charArray);
            Console.Read();
        }
    }
}
