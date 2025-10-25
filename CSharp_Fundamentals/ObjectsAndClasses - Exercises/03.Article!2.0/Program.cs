namespace _03.Article_2._0
{
    internal class Program
    {
        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }

            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();
            int articleNumber = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < articleNumber; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title =articleData[0];
                string content =articleData[1];
                string author =articleData[2];
                
                Article article = new Article(title, content, author);
               
                articleList.Add(article);
            }

            foreach (Article article in articleList)
            {
                Console.WriteLine(article);
            }
        }
    }
}
