using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args) {
            string name;
            int age;
            int ans = 6 & 3;
            Console.WriteLine(ans);
            Console.WriteLine("Hello World");
            Console.WriteLine("What is ur name");
            name= Console.ReadLine();
            Console.WriteLine("\b The User's name is : " + name);
            Console.WriteLine("What is the user's age");
            age= Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("The User's age is: ");
         
            Console.WriteLine(Math.Max(2,3));

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
      
    }
}
