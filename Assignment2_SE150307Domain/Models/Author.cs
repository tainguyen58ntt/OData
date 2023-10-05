using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Domain.Models
{
    public class Author
    {
        [Key]
        public int authorId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string emailAddress { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }    

    }
}
