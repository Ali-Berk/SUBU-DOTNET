using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
    public class TablePopulation
    {
        public int Year { get; set; }
        public int WomenPopulation { get; set; }
        public int ManPopulation { get; set; }
        public int OverallPopulation { get; set; }

        [Key]
        public int PopulationId { get; set; }
    }
}