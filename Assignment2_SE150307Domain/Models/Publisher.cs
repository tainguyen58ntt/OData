using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Domain.Models
{
    public class Publisher
    {
        [Key]
        public int pubId { get; set; }
        public string pubName { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
