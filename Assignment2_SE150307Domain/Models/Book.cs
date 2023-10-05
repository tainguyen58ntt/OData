using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Domain.Models
{
    public class Book

    {

        [Key]
        public int bookId { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public string advance { get; set; }
        public string royalty { get; set; }
        public string royaltyType { get; set; }
        public decimal ytdSales { get;set; }
        public string note { get;set; }
        public DateTime publishedDate { get; set; }

        public virtual Publisher Publisher { get; set; } = null!;

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
