using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiUdemy.Data.Models
{
    public class LibBook
    {
        [Key]
        public int BookId { get; set; }
        public string Book_Title { get; set; }
        public string Description { get; set; }
        public int Edition { get; set; }
        public bool isRead { get; set; }
        public DateTime? readTime { get; set; }
        public string Genre { get; set; }
        public DateTime addedDate { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}
