using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class CV
    {
        public int id { get; set; }
        public string competence { get; set; }
        public string education { get; set; }
        public string experience { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
        public virtual User users { get; set; }
    }
}
