using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Models
{
    public class Complaints
    {
        [Required]
        [Key]
        public int ComplaintID { get; set; }
        [Required]
        public string ComplainDescription { get; set; }

        public string FixDescription { get; set; }

        public string ComplainState { set; get; }

        public virtual Products ProductID { get; set; }

        public virtual Employer EmployerID { set; get; }
    }
}
