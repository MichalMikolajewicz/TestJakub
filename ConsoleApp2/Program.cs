using System;
using System.Linq;

namespace ConsoleApp2
{
    public interface ITest
    {
        int WTF { get; }

        void Default()
        {
            Console.WriteLine("asdcxz");
        }
    }

    public class Test : ITest
    {
        public int WTF => throw new NotImplementedException();
    }

    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new Test();
            test.Default();

            var range = Enumerable.Range(1, 100);
            range.Select(x => new { x });
           
            var x = 3;
            var y = 2 + ++x;
            x = 3 << 2;
            y = 10 >> 1;
            x = 10 & 8;
            y = 10 | 7;
        }
    }
}
