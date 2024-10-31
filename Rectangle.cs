using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD05
{
    public class Rectangle:GeoShape
    {
        public Rectangle()
        {
            Console.WriteLine("ctor of rect");
        }
        public Rectangle(double _dim1,  double _dim2):base(_dim1 , _dim2)
        {
            Console.WriteLine("ctor of 2p rect");

        }
    }
}
