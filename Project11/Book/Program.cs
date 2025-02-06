namespace Book
{
    internal class Program
    {
        //user defined
        public delegate String del1(Book b);

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() { };

            Book b = new Book("45f", "oop", new string[] { "z", "x" }, new DateTime(2020,7,2), 119.0m);


            //Bcl  delegate

            Func<Book, String> fptr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, fptr);


            // anonymous delegate
            fptr = delegate (Book b)
            {
                return b.ISBN;
            };
            LibraryEngine.ProcessBooks(books, fptr);

            //lamda delegate
            fptr = (Book B) => B.PublicationTime.ToString();
            LibraryEngine.ProcessBooks(books, fptr);







        }



    }
}
