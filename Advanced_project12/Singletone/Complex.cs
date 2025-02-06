using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Complex
    {
         public static Complex Shareable_obj = null;
        public int real {set; get;}

        public int img {set; get;}

        Complex(int _real = 0, int _img = 0)
        {
            this.real = _real;
            this.img = _img;
        }

        public static Complex CreateObjects(int realnum, int imgnum)
        {
           if (Shareable_obj == null)
            {
                Shareable_obj= new Complex(realnum, imgnum);
               
            }
            return Shareable_obj;


        }

       public override string ToString()
        {
            if (this.img < 0)
            {
                return $"{this.real}- {this.img}J";   
            }
            else
            {
                return $"{this.real}+ {this.img}J";
            }
        }

    }
}
