using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SayHi();
            int num = Add(8, 7);
            Console.WriteLine(num);
        
        }

        
        static void SayHi()
        {
            Console.WriteLine("Hi!");
            
        }
        

        static int Add(int x, int y)
        {
            int z = x + y;
            return z;
           

        }

    }
}
