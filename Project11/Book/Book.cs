using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public  class Book
    {
        public String ISBN { get; set; }
        public  String title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationTime { get; set; }

        public decimal Price {  get; set; }

        public Book( string _ISBN, String _title , string[] _Authors, DateTime _dtPublish,decimal _price)
        {
            this.ISBN = _ISBN;
            this.title = _title;
            this.Authors = _Authors;
            this.PublicationTime =_dtPublish;
            this.Price = _price;

        }

        public override string ToString()
        {
            return $"{this.ISBN},{this.title},{this.Price},{this.PublicationTime} ";
        }


    }

    
}
