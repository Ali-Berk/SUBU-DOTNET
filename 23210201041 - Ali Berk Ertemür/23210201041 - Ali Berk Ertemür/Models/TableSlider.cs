using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
    public class TableSlider
    {
        [Key]
        public int SliderId { get; set; }
        public string SliderLink { get; set; }
    }
}