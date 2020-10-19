using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCart2
{
    class checkout: IPromotion
    {
        List<merchandises> ListCourses { get; set; }

        public checkout(List<merchandises> fruits)
        {
            ListCourses = fruits;
        }

        public void Add(merchandises product)
        {
            ListCourses.Add(product);
        }

        public override string ToString()
        {
            string temp = null;
            for(int i=0;i<ListCourses.Count;i++)
            {
                temp = temp +" "+ ListCourses[i].name;
            }
            return temp;
        }


        public double Sum()
        {
            double sum = 0;
            for (int i = 0; i < ListCourses.Count; i++)
            {
                if (ListCourses[i].name == "apple")
                {
                    sum = sum + ListCourses[i].price;
                }
                else
                {
                    sum = sum + ListCourses[i].price;
                }
            }
            return sum;

        }

        public void PromoApple(merchandises name)
        {
            for(int i=0;i<ListCourses.Count;i++)
            {
                if(ListCourses[i].name=="apple")
                {
                    merchandises apple = new merchandises("apple", 0.60);
                    ListCourses.Add(apple);
                    break;
                }
            }
        }
    }
}
