using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class ReplaceWithAlphabetPosition
    {
        private static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        public static string AlphabetPosition(string text)
        {
            var st = new StringBuilder ();
            foreach (var pos in text.ToLower().Select (letter => Alphabet.IndexOf (letter) + 1).Where (pos => pos != 0)) {
                st.Append (pos);
                st.Append (' ');
            }
            return st.ToString().Trim();
        }
    }
}