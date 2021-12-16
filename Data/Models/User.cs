using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string password { get; set; }
        public bool privateProfile { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<CV> CVs { get; set; }
    }
}
