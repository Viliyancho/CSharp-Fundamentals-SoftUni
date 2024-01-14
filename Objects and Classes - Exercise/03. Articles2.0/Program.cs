using System;
using System.Collections.Generic;

namespace _03._Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> all = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = commandArgs[0];
                string content = commandArgs[1];
                string author = commandArgs[2];

                Article artc = new Article(title, content, author);
                all.Add(artc);
            }
            foreach (Article item in all)
            {
                Console.WriteLine(item.ToString());
            }
            string a = Console.ReadLine();
        }
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
            => $"{Title} - {Content}: {Author}";
        }
    }
}
