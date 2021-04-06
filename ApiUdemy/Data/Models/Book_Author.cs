using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Data.Models
{
    public class Book_Author
    {
        [Key]
        public int BookAuthorId { get; set; }

        public int BookId { get; set; }
        public LibBook LibBook { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
