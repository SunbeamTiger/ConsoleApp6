using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static void anothermethod()
        { }
        static void Main(string[] args)
        {
            Person Glinda = new Person(10, "Glinda");
            Console.WriteLine(Glinda.Count);
            Glinda = new Person(1, "Dan");
            Console.WriteLine(Glinda.Count);
            Glinda = new Person(-1, "Mac");
            Console.WriteLine(Glinda.Count);


            test.Add(2, 3);
            Program.anothermethod();
        }
    }
    class test
    {
        public static int Add( int x, int y)
        {
            return x + y;
        }
    }
    class Person
    {
        private static int counter = 0;
        private int _age;
        private string _name;
        public Person(int age, string name)
        {
            counter += 1;
            _age = age;
            _name = name;
        }
        public override Dispose()
        {
            counter -= 1;
        }
        public override void Finalize()
        { }

        public ~Person()
        {
            counter -= 1;
        }

        public int Count
        {
            get { return counter; }
        }



    }
}
