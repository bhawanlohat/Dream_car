using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream_car.Models
{
    public class Specification
    {
        public int Id { get; set; }
        [Required]
        public string Fuel_type { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public string GPS { get; set; }
        [Required]
        public string Rating { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
