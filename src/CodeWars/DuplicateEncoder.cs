using System;
using System.Linq;

namespace CodeWars
{
    public class DuplicateEncoder
    {
        const string OpenBracket = "(";
        const string CloseBracket = ")";

        public static string DuplicateEncode (string word)
        {
            var response = string.Empty;
            foreach (char character in word) {
                if (word.Count (c =>
                    string.Equals (c.ToString (), character.ToString (), StringComparison.OrdinalIgnoreCase)) > 1) {
                    response += CloseBracket;
                } else {
                    response += OpenBracket;
                }
            }

            return response;
        }
    }
}