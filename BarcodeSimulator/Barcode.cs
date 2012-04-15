using System;
using System.Collections.Generic;
using System.Linq;

namespace BarcodeSimulator
{

    public static class Barcode
    {

        public static string GetTypeName(string input)
        {
            if (IsUpcA(input)) return "UPC-A";
            if (IsEan13(input)) return "EAN-13";
            if (IsEan8(input)) return "EAN-8";
            if (IsCode39(input)) return "Code39";
            return "Text";
        }

        public static bool IsUpcA(string input)
        {
            if (input.Length != 12)
                return false;

            if (!input.ToCharArray().All(char.IsDigit))
                return false;

            var digits = input.ToCharArray(0, 11).Select(CharCodeOfNumberToInt).ToArray();
            var odds = Odds(digits).Sum();
            var evens = Evens(digits).Sum();
            var result = 10 - ((odds*3 + evens) % 10);
            
            return CharCodeOfNumberToInt(input[11]) == result;
        }

        public static bool IsEan13(string input)
        {
            return input.Length == 13 && IsEan(input);
        }

        public static bool IsEan8(string input)
        {
            return input.Length == 8 && IsEan(input);
        }

        public static bool IsCode39(string input)
        {
            return input.Length > 2 && input[0] == '*' && input.Last() == '*' && input.ToCharArray().All(IsCode39Char);
        }

        private static bool IsCode39Char(char c)
        {
            return (c >= 0x41 && c <= 0x5a) // A-Z (uppercase only)
                   || (c >= 0x30 && c <= 0x39) // 0-9
                   || (new[] {'*', ' ', '-', '$', '%', '.', '/', '+'}.Contains(c));
        }

        private static bool IsEan(string input)
        {
            if (!input.ToCharArray().All(char.IsDigit))
                return false;

            // take each character, turn it into an integer, then reverse the list
            // we reverse it because every odd-numbered (1-based counting) digit counting from the END
            // is multiplied by 3. 
            var digits = input.ToCharArray(0, input.Length - 1).Select(CharCodeOfNumberToInt).Reverse().ToArray();
            var odds = Odds(digits).Sum() * 3;
            var evens = Evens(digits).Sum();
            var total = odds + evens;

            return 10 - (total % 10) == CharCodeOfNumberToInt(input.Last());
        }

        /// <summary>
        /// Takes the ASCII character code of a number and converts it to an integer.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <example>>CharCodeOfNumberToInt('8') => 8</example>
        private static int CharCodeOfNumberToInt(char c)
        {
            var code = (int) c;

            if (code < 48 || code > 57)
                throw new ArgumentException("This character code is not for a number", "c");

            return code - 48;
        }

        public static IEnumerable<T> Odds<T>(T[] source)
        {
            return Enumerable.Range(0, source.Count()).Where(i => i%2 == 0).Select(i => source[i]);
        }

        public static IEnumerable<T> Evens<T>(T[] source) {
            return Enumerable.Range(0, source.Count()).Where(i => i % 2 != 0).Select(i => source[i]);
        }
    }
}