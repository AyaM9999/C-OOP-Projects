using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Subjects
    {

        String id  {set; get;}
        String subName { set; get; }

        public Subjects(String _id = "", String _name=" ")
        {
            this.id= _id;
            this.subName= _name;    
        }



    }
}
