using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
    public class TableFamousPlace
    {
        [Key]
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
    }
}