using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //orange = 60;
            //apple = 25;
            merchandises apple = new merchandises("apple", 0.60);
            merchandises orange = new merchandises("orange", 0.25);
            merchandises banana = new merchandises("banana", 0.15);
            merchandises chair = new merchandises("orange", 25);

            List<merchandises> fruits = new List<merchandises>();            
            fruits.Add(orange);
            fruits.Add(apple);
            fruits.Add(apple);
            fruits.Add(apple);
            checkout ListCourses = new checkout(fruits);

            ListCourses.Promo(apple);
            Console.WriteLine("Shopping List:");
            Console.WriteLine(ListCourses.ToString());
            Console.WriteLine($"You need to pay £{ListCourses.Sum()}");
            Console.ReadKey();

            Console.WriteLine("test");
        }

        


    }
}
