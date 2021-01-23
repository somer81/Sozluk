using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MyDictionary<string, decimal> products = new MyDictionary<string, decimal>();
                products.Add("Smart TV", 1000);
                products.Add("Iphone", 4000);
                products.Add("Samsung Tablet", 500);

                var p = products._values; 


                foreach(var v in p)
                {
                    Console.WriteLine(v);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }



}
