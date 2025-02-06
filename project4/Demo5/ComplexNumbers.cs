using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    internal class ComplexNumbers
    {
        int realPart=0;
        int imaginaryPart=0;
        static int counter=0;


        // ctors Chaining

        

   


        public ComplexNumbers(int realNum, int imaginNum) 
        { 
             this.realPart = realNum;
             this.imaginaryPart = imaginNum;
             counter++;
        }



        // setter && getter
        public void SeRealNum(int _realPart)
        {
           this. realPart = _realPart;
           
        }

        public int GetRealNum() { return this.realPart; }

        public void SetImaginaryNum( int _imaginaryPart)
        {
            
            this.imaginaryPart = _imaginaryPart;
        }
        public int GetImaginaryNum() { return this.imaginaryPart + 'j'; }

        public void PrintComplexNum()
        {
            if ( imaginaryPart>0) 
            {
                Console.WriteLine($"Complex Number= {this.realPart}+{this.imaginaryPart}j");
            }
            else
            {  
                   Console.WriteLine($"Complex Number= {this.realPart}-{this.imaginaryPart}j");
                
            }
            
        }

        
    }
}
