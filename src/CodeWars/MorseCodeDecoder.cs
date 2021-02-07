using System.Collections.Generic;
using System.Linq;

/*
In this kata you have to write a simple Morse code decoder. While the Morse code is now mostly superseded by voice and digital data communication channels, it still has its use in some applications around the world.
The Morse code encodes every character as a sequence of "dots" and "dashes". For example, the letter A is coded as ·−, letter Q is coded as −−·−, and digit 1 is coded as ·−−−−. The Morse code is case-insensitive, traditionally capital letters are used. When the message is written in Morse code, a single space is used to separate the character codes and 3 spaces are used to separate words. For example, the message HEY JUDE in Morse code is ···· · −·−−   ·−−− ··− −·· ·.

NOTE: Extra spaces before or after the code have no meaning and should be ignored.

In addition to letters, digits and some punctuation, there are some special service codes, the most notorious of those is the international distress signal SOS (that was first issued by Titanic), that is coded as ···−−−···. These special codes are treated as single special characters, and usually are transmitted as separate words.

Your task is to implement a function that would take the morse code as input and return a decoded human-readable string.

For example:

MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .")
//should return "HEY JUDE"
NOTE: For coding purposes you have to use ASCII characters . and -, not Unicode characters.

The Morse code table is preloaded for you as a dictionary, feel free to use it:

Coffeescript/C++/Go/JavaScript/Julia/PHP/Python/Ruby/TypeScript: MORSE_CODE['.--']
C#: MorseCode.Get(".--") (returns string)
Elixir: @morse_codes variable (from use MorseCode.Constants). Ignore the unused variable warning for morse_codes because it's no longer used and kept only for old solutions.
Elm: MorseCodes.get : Dict String String
Haskell: morseCodes ! ".--" (Codes are in a Map String String)
Java: MorseCode.get(".--")
Kotlin: MorseCode[".--"] ?: "" or MorseCode.getOrDefault(".--", "")
Rust: self.morse_code
Scala: morseCodes(".--")
Swift: MorseCode[".--"] ?? "" or MorseCode[".--", default: ""]
C: provides parallel arrays, i.e. morse[2] == "-.-" for ascii[2] == "C"
All the test strings would contain valid Morse code, so you may skip checking for errors and exceptions. In C#, tests will fail if the solution code throws an exception, please keep that in mind. This is mostly because otherwise the engine would simply ignore the tests, resulting in a "valid" solution.

Good luck!
 */
namespace CodeWars
{
	public static class MorseCodeDecoder
	{
		public static string Decode (string morseCode)
		{
			morseCode = morseCode.Trim().Replace("  ", " _");
			var splitted = morseCode.Split (" ");
			var decoded = string.Empty;
			foreach (var letter in splitted) {
				if (letter == "_") {
					decoded += " ";
				} else {
					decoded += MorseCode.Get (letter);
				}
			}
			return decoded;		
		}
	}

	internal static class MorseCode
	{
		private const char Dot = '.';
		private const char Dash = '-';
		
		private static readonly IDictionary<char, string> MorseDictionary;

		static MorseCode ()
		{
			MorseDictionary = new Dictionary<char, string> {
				{'a', string.Concat(Dot, Dash)},
				{'b', string.Concat(Dash, Dot, Dot, Dot)},
				{'c', string.Concat(Dash, Dot, Dash, Dot)},
				{'d', string.Concat(Dash, Dot, Dot)},
				{'e', Dot.ToString()},
				{'f', string.Concat(Dot, Dot, Dash, Dot)},
				{'g', string.Concat(Dash, Dash, Dot)},
				{'h', string.Concat(Dot, Dot, Dot, Dot)},
				{'i', string.Concat(Dot, Dot)},
				{'j', string.Concat(Dot, Dash, Dash, Dash)},
				{'k', string.Concat(Dash, Dot, Dash)},
				{'l', string.Concat(Dot, Dash, Dot, Dot)},
				{'m', string.Concat(Dash, Dash)},
				{'n', string.Concat(Dash, Dot)},
				{'o', string.Concat(Dash, Dash, Dash)},
				{'p', string.Concat(Dot, Dash, Dash, Dot)},
				{'q', string.Concat(Dash, Dash, Dot, Dash)},
				{'r', string.Concat(Dot, Dash, Dot)},
				{'s', string.Concat(Dot, Dot, Dot)},
				{'t', string.Concat(Dash)},
				{'u', string.Concat(Dot, Dot, Dash)},
				{'v', string.Concat(Dot, Dot, Dot, Dash)},
				{'w', string.Concat(Dot, Dash, Dash)},
				{'x', string.Concat(Dash, Dot, Dot, Dash)},
				{'y', string.Concat(Dash, Dot, Dash, Dash)},
				{'z', string.Concat(Dash, Dash, Dot, Dot)},
				{'0', string.Concat(Dash, Dash, Dash, Dash, Dash)},
				{'1', string.Concat(Dot, Dash, Dash, Dash, Dash)},
				{'2', string.Concat(Dot, Dot, Dash, Dash, Dash)},
				{'3', string.Concat(Dot, Dot, Dot, Dash, Dash)},
				{'4', string.Concat(Dot, Dot, Dot, Dot, Dash)},
				{'5', string.Concat(Dot, Dot, Dot, Dot, Dot)},
				{'6', string.Concat(Dash, Dot, Dot, Dot, Dot)},
				{'7', string.Concat(Dash, Dash, Dot, Dot, Dot)},
				{'8', string.Concat(Dash, Dash, Dash, Dot, Dot)},
				{'9', string.Concat(Dash, Dash, Dash, Dash, Dot)}
			};
		}
		
		public static string Get (string morseCode)
		{
			var letter = MorseDictionary.FirstOrDefault (x => x.Value == morseCode).Key.ToString();
			return letter.ToUpper();
		}

	}
}
