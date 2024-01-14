using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article paper = new Article(article);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                if(command == "Edit")
                {
                    paper.Content = commandArgs[1];
                }
                else if(command == "ChangeAuthor")
                {
                    paper.Author = commandArgs[1];
                }
                else if(command == "Rename")
                {
                    paper.Title = commandArgs[1];
                }
            }
            Console.WriteLine(paper.ToString());

        }
    }
    public class Article
    {
        public Article(string[] article)
        {
            Title = article[0];
            Content = article[1];
            Author = article[2];
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        =>  $"{Title} - {Content}: {Author}";
    }

}
