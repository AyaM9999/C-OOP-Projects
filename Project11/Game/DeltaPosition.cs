using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
     public class DeltaPosition :EventArgs
        // extra data that assigned with event inherits from event argus
        //the class taht i sent extra data through it ,must inherits from EventArgus class
    {

        public int delta_X {  get; set; }

        public int delta_Y { get; set; }

    }
}
