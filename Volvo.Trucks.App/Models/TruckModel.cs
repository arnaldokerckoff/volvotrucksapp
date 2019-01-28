using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo.Trucks.App.Models
{
    public class TruckModel
    {
        [Display(Description = "Model")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
