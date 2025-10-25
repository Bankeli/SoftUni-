
namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }

        public int CompareTo(Book other)
        {
           var yearComparison = this.Year.CompareTo(other.Year);
            if (yearComparison != 0)
            {
                return yearComparison;
            }
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            return $"{this. Title} - {this.Year}";
        }
    }
}
