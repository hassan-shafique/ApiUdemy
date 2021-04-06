using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Data.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string Publisher_Name { get; set; }

        public List<LibBook> LibBook { get; set; }


    }
}
