using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Domain.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string emailAddress { get; set; }
        public string password { get; set; }
        public string source { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int roleId { get; set; }
        public int pubId { get; set; }
        public DateTime hireDate { get; set; }


        public virtual Role Role { get; set; } = null!;
        public virtual Publisher Publisher { get; set; } = null!;
    }
}
