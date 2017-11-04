using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Test();
            Console.ReadLine();
        }
        static void Test()
        {
            Stack<Person> test = new Stack<Person>();

            test.Push(new Person(21, "ADEL1"));
            test.Push(new Person(11, "IRMA2"));
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(new Person(37, "AMY3"));
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(new Person(44, "RODICK4"));
            test.Push(new Person(30, "NOVAK5"));
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: {0}", test.Peek());
           

        }
    }
}

