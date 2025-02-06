using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    public enum Color :int {
         red,green, blue
    }
    public class Carcs
    {
        String model {  get; set; }
        Enum Color {  get; set; }

        String manfacuture {  get; set; }

        public Carcs(String model, Enum Color)
        {
            this.model = model;
            this.Color = Color;
        }

        public override String ToString() 
         {
            return $" car model:{this.model}, Color:{this.Color}";
        }
        
    }
}
