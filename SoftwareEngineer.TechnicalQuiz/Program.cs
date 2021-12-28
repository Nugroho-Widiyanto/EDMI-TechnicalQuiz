using System;
using System.Linq;

namespace SoftwareEngineer.TechnicalQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEdmi edmi = new Edmi();

            Console.WriteLine("(Number 1)");
            Console.WriteLine("==========");
            var wordCounts1 = edmi.GetWordCounts(new[] { "one", "two", "two", "three", "three", "three", "four" });
            // Expected output:
            // wordCounts1 should be { {"one", 1}, {"two", 2}, {"three", 3"}, {"four", 1} }
            wordCounts1.ToList().ForEach(x => Console.WriteLine(x.Item1 + " - " + x.Item2));
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 2)");
            Console.WriteLine("==========");
            var wordCounts2 = edmi.GetWordCounts("one,two, two, three, three, three, three,Four,four");
            // Expected output:
            // wordCounts2 should be { {"one", 1}, {"two", 2}, {"three", 4"}, {"Four", 1}, {"four", 1} }
            wordCounts2.ToList().ForEach(x => Console.WriteLine(x.Item1 + " - " + x.Item2));
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 3)");
            Console.WriteLine("==========");
            var bit0 = edmi.IsBitSet(9, 0);
            // Expected output:
            // bit0 should be true, since bit-0 of integer 9 is set
            Console.WriteLine("bit0 - " + bit0);
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 4)");
            Console.WriteLine("==========");
            var bit1 = edmi.IsBitSet(9, 1);
            // Expected output:
            // bit1 should be false, since bit-1 of integer 9 is not set
            Console.WriteLine("bit1 - " + bit1);
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 5)");
            Console.WriteLine("==========");
            var bit2 = edmi.IsBitSet(9, 2);
            // Expected output:
            // bit2 should be false, since bit-2 of integer 9 is not set
            Console.WriteLine("bit2 - " + bit2);
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 6)");
            Console.WriteLine("==========");
            var bit3 = edmi.IsBitSet(9, 3);
            // Expected output:
            // bit3 should be true, since bit-3 of integer 9 is set
            Console.WriteLine("bit3 - " + bit3);
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 7)");
            Console.WriteLine("==========");
            var bitsSet = edmi.GetBitsSet(9);
            // Expected output:
            // bitsSet should be {0, 3}, since bit-0 and bit-3 of integer 9 are set
            bitsSet.ToList().ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 8)");
            Console.WriteLine("==========");
            var newValue = edmi.SetBits(9, new[] { 2 });
            // Expected output:
            // newValue should be 13, since bit-2 of integer 9 are now set
            Console.WriteLine("newValue - " + newValue);
            Console.WriteLine("==========");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("(Number 9)");
            Console.WriteLine("==========");
            var newBitsSet = edmi.GetBitsSet(newValue);
            // Expected output:
            // newBitsSet should be {0, 2, 3}, since bit-0, bit-1 and bit-3 of integer 13 are set
            newBitsSet.ToList().ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("==========");
        }
    }
}
