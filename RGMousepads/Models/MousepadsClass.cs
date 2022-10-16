using System;
using System.ComponentModel.DataAnnotations;

namespace RGMousepads.Models
{
    public class MousepadsClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        [Display(Name = "Size(CM)")]
        public string Size { get; set; }

        public string color { get; set; }

        public string shape { get; set; }

        public int ModelNumber { get; set; }

        [Range (1,5)]
        public double Review { get; set; }
    }
}
