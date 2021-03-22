/*
 ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
 ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special 
characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet 
should be shifted, like in the original Rot13 "implementation".
 */

using System;
using System.Text;

namespace CodeWars
{
    public class Rot13
    {
        public static string Translate(string message)
        {
            const string part1 = "abcdefghijklm";
            const string part2 = "nopqrstuvwxyz";
            var sb = new StringBuilder();
            foreach (var letter in message)
            {
                var indexInPart1 = part1.IndexOf(letter.ToString().ToLower());
                var indexInPart2 = part2.IndexOf(letter.ToString().ToLower());
                string translatedChar = default;
                if (indexInPart1 != -1)
                {
                    translatedChar = part2.Substring(indexInPart1, 1);
                } else if (indexInPart2 != -1)
                {
                    translatedChar = part1.Substring(indexInPart2, 1);
                }
                else
                {
                    translatedChar = letter.ToString();
                }

                if (Char.IsUpper(letter))
                {
                    translatedChar = translatedChar.ToUpper();
                }
                sb.Append(translatedChar);
            }

            return sb.ToString();
        }
    }
}