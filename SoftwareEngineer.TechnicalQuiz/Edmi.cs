using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareEngineer.TechnicalQuiz
{
    internal class Edmi : IEdmi
    {
        public IEnumerable<Tuple<string, int>> GetWordCounts(string[] words)
        {
            return words
                .ToList()
                .GroupBy(x => x)
                .Select(x => new Tuple<string, int>(x.Key, x.Count()));
        }

        public IEnumerable<Tuple<string, int>> GetWordCounts(string commaDelimitedWords)
        {
            return commaDelimitedWords
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .GroupBy(x => x)
                .Select(x => new Tuple<string, int>(x.Key, x.Count()));
        }

        public bool IsBitSet(int value, int bit)
        {
            return (value & (1 << bit)) != 0;
        }

        public IEnumerable<int> GetBitsSet(int value)
        {
            var chars = Convert.ToString(value, 2)
                .ToCharArray()
                .Reverse()
                .ToArray();

            return Enumerable.Range(0, chars.Length)
                .Where(i => chars[i] == '1');
        }

        public int SetBits(int value, int[] bitsToSet)
        {
            bitsToSet.ToList().ForEach(x => { value |= (1 << x); });
            return value;
        }
    }
}
