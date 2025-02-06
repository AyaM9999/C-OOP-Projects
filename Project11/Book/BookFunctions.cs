using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookFunctions
    {
        public List<Book> books = new List<Book>();

        public static string GetTitle(Book book)
        {
            if(book != null)
            {
                return book.title;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static string GetAuthors(Book book)
        {
            if (book != null)
            {
                return book.Authors.ToString();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public static string GetPrice(Book book) 
        {

            if (book != null)
            {
                return book.Price.ToString();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
