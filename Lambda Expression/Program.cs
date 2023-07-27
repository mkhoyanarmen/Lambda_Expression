using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        delegate int SubDel(int a, int b);
        static void Main(string[] args)
        {
            SubDel op = (a, b) => a + b;
            Console.WriteLine(op(5, 6));

            int sum = new SubDel((a, b) => a - b).Invoke(89, 5);
            Console.WriteLine(sum);

            Func();
        }
        static void Func() => Console.WriteLine("The End");
    }
}
