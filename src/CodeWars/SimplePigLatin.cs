/*
 Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
 */
namespace CodeWars
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            var splitted = str.Split(" ");
            str = "";
            foreach (var word in splitted)
            {
                if (word.Length > 1)
                {
                    str += $"{word.Substring(1)}{word.Substring(0, 1)}ay ";
                }
                else
                {
                    str += word;
                }
            }
            return str.Trim();
        }
    }
}