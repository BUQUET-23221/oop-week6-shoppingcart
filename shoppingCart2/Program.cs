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
            merchandises apple = new merchandises("apple", 60);
            merchandises orange = new merchandises("orange", 25);


            List<merchandises> fruits = new List<merchandises>();
            fruits.Add(orange);
            fruits.Add(apple);
            fruits.Add(apple);
            fruits.Add(apple);

            Console.WriteLine("Shopping List:");
            for(int i=0;i<fruits.Count;i++)
            {
                Console.WriteLine(fruits[i].name);
            }
            Console.WriteLine($"You need to pay £{Sum(fruits)}");
            Console.ReadKey();
            Console.WriteLine("test");
        }

        static int Sum(List<merchandises> fruits)
        {
            int sum = 0;
            for(int i=0;i<fruits.Count;i++)
            {
                if(fruits[i].name=="apple")
                {
                    sum = sum + 60;
                }
                else
                {
                    sum = sum + 25;
                }
            }
            return sum/100;
            
        }


    }
}
