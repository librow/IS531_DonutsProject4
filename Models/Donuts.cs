using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS531_DonutsProject.Models
{
    public partial class Donuts
    {
        [Key]
        public int DonutId { get; set; }
        public string Donut_name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Donut_Description { get; set; }
        public string image_url { get; set; }
    }
}
