using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleTokens = Console.ReadLine().Split(", ");
            Article myArticle = new Article(articleTokens[0], articleTokens[1], articleTokens[2]);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] comand = Console.ReadLine().Split(": ");
                string cmd = comand[0];

                if (cmd == "Edit")
                {
                    myArticle.Edit(comand[1]);
                }
                else if (cmd =="ChangeAuthor")
                {
                    myArticle.ChangeAuthor(comand[1]);
                }
                else if (cmd == "Rename")
                {
                    myArticle.Rename(comand[1]);
                }
            }
            Console.WriteLine(myArticle.ToString());
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

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
