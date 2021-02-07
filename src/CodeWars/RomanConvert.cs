/*
Create a function taking a positive integer as its parameter and returning a string containing 
the Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the 
left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is 
rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; 
or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

Example:

RomanConvert.Solution(1000) -- should return "M"
Help:

Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000
Remember that there can't be more than 3 identical symbols in a row.

More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals
 */
using System.Text;

namespace CodeWars
{
    public static class RomanConvert
    {
        public static string Solution(int n)
        {
            var numberAsString = n.ToString ();
            int units = 0, tens = 0, hundreds = 0, thousands = 0;
            if (n > 0) {
                units = int.Parse (numberAsString.Substring (numberAsString.Length - 1, 1));
            }

            if (n > 9) {
                tens = int.Parse (numberAsString.Substring (numberAsString.Length - 2, 1));
            }

            if (n > 99) {
                hundreds = int.Parse (numberAsString.Substring (numberAsString.Length - 3, 1));
            }

            if (n > 999) {
                thousands = int.Parse (numberAsString.Substring (0, numberAsString.Length - 3));
            }
            
            var st = new StringBuilder();
            st.Append (new string ('M', thousands));
            st.Append (ComposeRomanNumber (hundreds, 'C', 'D', 'M'));
            st.Append (ComposeRomanNumber (tens, 'X', 'L', 'C'));
            st.Append (ComposeRomanNumber (units, 'I', 'V', 'X'));
            return st.ToString();
        }

        private static string ComposeRomanNumber (int part, char min, char medium, char max)
        {
            if (part == 0) {
                return string.Empty;
            }
            var st = new StringBuilder();
            if (part < 4) {
                st.Append (min, part);
            } else if (part == 4) {
                st.Append (min);
                st.Append (medium);
            } else if (part < 9) {
                st.Append (medium);
                st.Append (new string (min, part - 5));
            } else {
                st.Append (min);
                st.Append (max);
            }
            return st.ToString ();
        }
    }
}