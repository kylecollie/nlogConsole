using System;

namespace LoopXML
{
    class Book
    {
        public string id { get; set; }
        public string author {get;set;}
        public string title {get;set;}
        public string genre {get;set;}
        public decimal price {get;set;}
        public DateTime publishDate {get;set;}
        public string description {get;set;}

        public Book()
        {
            this.id = null;
            this.author = null;
            this.title = null;
            this.genre = null;
            this.price = 0;
            this.publishDate = DateTime.MinValue;
            this.description = null;
        }

        public Book(string id, string a, string t, string g, decimal p, DateTime pd, string d)
        {
            this.id = id;
            this.author = a;
            this.title = t;
            this.genre = g;
            this.price = p;
            this.publishDate = pd;
            this.description = d;
        }
    }
}