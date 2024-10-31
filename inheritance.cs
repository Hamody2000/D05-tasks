using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD05
{
    public class Base
    {
        protected int x;
        protected int y;

        #region properties
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        #endregion


        public Base()
        {

        }
        public Base(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public virtual void Show()
        {
            Console.WriteLine("I'm Base");
        }
    }
    public class Derived : Base
    {
        public override void Show()
        {
            Console.WriteLine("Iam derived");
        }
    }

}
