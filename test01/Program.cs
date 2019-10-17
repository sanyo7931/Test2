using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Random random = new Random(DateTime.Now.Millisecond);
            for(int i=0;i<10;i++)
            { 
                int randomNum = random.Next(10);
                Console.WriteLine(randomNum);
            }
            Console.WriteLine("Stop");
            Console.ReadKey();
        }
    }
}