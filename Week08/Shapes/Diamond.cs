using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Diamond : Shapes
    {
        public double Length { set; get; }
        public double Width { set; get; }

        public Diamond (double length, double width)
        {
            Name = "Diamond";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length og {Length} and Width og {Width} ");
        }
    }
}
