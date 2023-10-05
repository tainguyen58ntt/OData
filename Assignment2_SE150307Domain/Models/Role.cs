using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Domain.Models
{
    public class Role
    {
        [Key]
        public int roleId { get; set; }
        public int roleDescription { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }   
}
