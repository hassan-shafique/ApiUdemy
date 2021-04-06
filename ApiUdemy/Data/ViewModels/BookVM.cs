using System;
using System.Collections.Generic;

namespace ApiUdemy.Data.ViewModels
{
    public class BookVM
    {
        public string Book_Title { get; set; }
        public string Description { get; set; }
        public int Edition { get; set; }
        public bool isRead { get; set; }
        public DateTime? readTime { get; set; }
        public string Genre { get; set; }
        public int PublisherId { get; set; }
        public List<int> Authorids { get; set; }
    }

    public class BookWithAuthorsVM
    {
        public string Book_Title { get; set; }
        public string Description { get; set; }
        public int Edition { get; set; }
        public bool isRead { get; set; }
        public DateTime? readTime { get; set; }
        public string Genre { get; set; }
        public string PublisherName { get; set; }
        public List<string> AuthorNames { get; set; }
    }
}
