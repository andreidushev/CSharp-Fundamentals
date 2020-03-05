using System;
using System.Collections.Generic;
using System.Linq;

namespace Article_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                Article myArticle = new Article(tokens[0], tokens[1], tokens[2]);
                list.Add(myArticle);
            }

            string criteria = Console.ReadLine();
            List<Article> orderlist = new List<Article>();

            if (criteria == "title")
            {
                orderlist = list.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "author")
            {
                orderlist = list.OrderBy(a => a.Author).ToList();
            }
            else if (criteria =="content")
            {
                orderlist = list.OrderBy(a => a.Content).ToList();
            }

            foreach (var item in orderlist)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Article
    {
        public Article(string Title, string Content, string Author)
        {
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
