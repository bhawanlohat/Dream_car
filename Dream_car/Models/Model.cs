using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream_car.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        public string Model_Name { get; set; }
        [Required]
        public string Model_Year { get; set; }
        public int Company_Id { get; set; }
        public Company Company { get; set; }
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
    }
}
