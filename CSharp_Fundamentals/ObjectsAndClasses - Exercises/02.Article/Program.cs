namespace _02.Article
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

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor (string newAuthor)
            {
                Author = newAuthor;
            }

            public void Rename (string newTitle)
            {
                Title = newTitle;
            }
        }
        static void Main(string[] args)
        {
            string[] dataArticles = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = dataArticles[0];
            string content = dataArticles[1];
            string author = dataArticles[2];

            Article article = new Article(title, content, author);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commandArguments = Console.ReadLine().Split(": ");
                string command = commandArguments[0];
                string data = commandArguments[1];

                switch(command)
                {
                    case "Edit":
                        article.Edit(data);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(data);
                        break;

                    case "Rename":
                        article.Rename(data);
                        break;
                }

            }
            Console.WriteLine(article);
        }
    }
}
