
namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
           var titleComparison = first.Title.CompareTo(second.Title);
            if (titleComparison != 0)
                return titleComparison;

            return second.Year.CompareTo(first.Year);
        }
    }
}
