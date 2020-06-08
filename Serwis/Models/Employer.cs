using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Models
{
    public class Employer
    {
        [Required]
        [Key]
        public int EmployerID { get; set; }
        [Required]
        public string EmployerLogin { get; set; }
        [Required]
        public string EmployerPassword { get; set; }
        [Required]
        public string EmployerName { get; set; }
        [Required]
        public string EmployerVorname { get; set; }
        public string EmployerPhone { get; set; }
        public string EmployerEmail { get; set; }
        public string Specialist { get; set; }

        public virtual IEnumerable<Complaints> Complaints { set; get; }
    }
}
