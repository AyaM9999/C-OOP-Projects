using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public  class LibraryEngine
    {
    

       

        public static void ProcessBooks(List<Book> books,Func<Book,string> fptr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fptr(book));
            }
        }

         
    }
}
