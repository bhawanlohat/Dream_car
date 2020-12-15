using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream_car.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        [Required]
        public string Dealer_Name { get; set; }
        public string Dealer_Website { get; set; }
        [Required]
        public string Dealer_Address { get; set; }
        [Required]
        public string Dealer_Email { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
