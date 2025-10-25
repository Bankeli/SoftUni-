
using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> libraryBooks;

        public Library(params Book[] books)
        {
            this.libraryBooks = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.libraryBooks.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {

            private List<Book> books;
            private int index;
            public LibraryIterator(List<Book> books)
            { 
                this.books = books;
                this.Reset();
            }
            public Book Current
            {
                get
                {  return this.books[index]; }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                this.index++;
                if (this.index >= this.books.Count)
                    return false;
                return true;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}
