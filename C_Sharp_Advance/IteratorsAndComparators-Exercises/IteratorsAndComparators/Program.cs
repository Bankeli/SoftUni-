namespace IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstBook = new Book("The Last Of Us", 2022, "Naughty Dogs");
            var secondBook = new Book("The Lord of the rings", 1998, "J.R.Tolkin");
            var thirdBook = new Book("Game of thrones", 2005, "George Martin");
            var fifthBook = new Book("Kill the Devil", 2009, "Somebody Else");
            var fourthBook = new Book("Kill the Devil", 2005, "Somebody Else");
            Library library = new Library();
            Library second = new Library(firstBook, secondBook, thirdBook, fourthBook,fifthBook);

            foreach (var book in second)
                Console.WriteLine(book);

            //foreach (var book in second)
            //    Console.WriteLine(book.Authors[0]);

            var sortedBook = new SortedSet<Book>
            {
                firstBook,
                secondBook,
                thirdBook
            };

            //foreach (var book in sortedBook)
            //    Console.WriteLine(book);
        }
    }
}
