using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo.Trucks.App.Models
{
    public class Truck
    {
        [Display(Description = "Code")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        [StringLength(20)]
        public string Version { get; set; }
        [Required]
        [Display(Description = "Model")]
        public int TruckModelID { get; set; }
        public List<TruckModel> TruckModelCollection { get; set; }
    }
}
