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
            //apple = 40;

            List<string> fruits = new List<string>();
            fruits.Add("Orange");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add("Orange");

            Console.WriteLine("Shopping List:");
            for(int i=0;i<fruits.Count;i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine($"You need to pay £{Sum(fruits)}");
            Console.ReadKey();
        }

        static int Sum(List<string> fruits)
        {
            int sum = 0;
            for(int i=0;i<fruits.Count;i++)
            {
                if(fruits[i]=="Orange")
                {
                    sum = sum + 60;
                }
                else
                {
                    sum = sum + 40;
                }
            }
            return sum/100;
            
        }


    }
}
