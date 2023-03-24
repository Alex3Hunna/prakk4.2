using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakk4._2
{
    internal class Program
    {

        class Order
        {
            public int Weight { get;  set; }
       
            public string Desc { get; set; }


            public Order( string desc, int weight)
            {
                Desc= desc;
                Weight = weight;
                
                

            }

            public void Use()
            {
                
               
                Console.WriteLine(Desc);
            }
        }

        class ServiceD
        {
            public int Weight { get; private set; }
           

            public ServiceD(int weight)
            {
                Weight= weight;
                
            }

           

            public void MakeDel(Order order)
            {

                if ((Weight + order.Weight) <=100)
                {

                    Console.Write("Send: ");
                    Weight += order.Weight;
                    order.Use();
                }

                else
                {
                    Console.WriteLine("Error! Ur bag so hard.");
                }
            }
        }
        static void Main(string[] args)
        {
            Order cap = new Order("cap no 1", 70);
            Order tshirt = new Order("treehunnathirt", 40);

            ServiceD service1 = new ServiceD(30);

            service1.MakeDel(cap);
            service1.MakeDel(tshirt);



            Console.ReadKey(true);
        }
    }
}
