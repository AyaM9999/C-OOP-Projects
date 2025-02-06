using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaps
{
    internal struct ComplexNumbers
    {
         public int realPart;
         public int imgPart;

        public ComplexNumbers()
        {

        }
        public ComplexNumbers(int _realPart, int _imgPart)
        {
            this.realPart = _realPart;
            this.imgPart = _imgPart;
        }

        public void setRealNum(int _realPart) 
        {
            this.realPart= _realPart;
        }
        public int GetReallNum()
        {
             return  this.realPart;
        }

        public void setImgNum(int _imgPart)
        {
            this.imgPart = _imgPart;
        }
        public int GetImglNum()
        {
            return this.imgPart;
        }

        public void Print()
        {
            if (this.imgPart <= 0) 
            {
                Console.WriteLine($"Complex Number = {this.realPart}+{this.imgPart}J");
            }
            else
            {
                Console.WriteLine($"Complex Number = {this.realPart}-{this.imgPart}J");
            }
        }



    }
}
