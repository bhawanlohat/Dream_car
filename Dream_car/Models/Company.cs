using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream_car.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Company_Name { get; set; }
        [Required]
        public string Company_Website { get; set; }
        public string Company_Phone { get; set; }
        public string Company_Email { get; set; }
        public string Company_Headquater { get; set; }
    }
}
