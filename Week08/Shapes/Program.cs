using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Shapes[] shapes = { new Circle(5), new Diamond(4, 5) };

            foreach(Shapes s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;
                if(testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if( s is Circle)
                {
                    Console.WriteLine("This isn't a Diamond";)
                }

                Console.WriteLine();

                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;

                Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());


            }


            Console.ReadLine();


        }
    }
}
