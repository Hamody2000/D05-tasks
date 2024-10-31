using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD05
{
    public abstract class GeoShape
    {
        double dim1;
        double dim2;


        #region properties
        public double Dim1
        {
            get
            {
                return dim1;
            }

            set
            {
                dim1 = value;
            }
        }

        public double Dim2
        {
            get
            {
                return dim2;
            }

            set
            {
                dim2 = value;
            }
        }
        #endregion

        public GeoShape()
        {
            Console.WriteLine("Geo def ctor");
        }

        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            Console.WriteLine("Geo 2p ctor");
        }

    }
}
