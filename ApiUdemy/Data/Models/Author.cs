using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Data.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }


        //Navigations Properties
        public List<Book_Author> Book_Authors { get; set; }
    }
}
