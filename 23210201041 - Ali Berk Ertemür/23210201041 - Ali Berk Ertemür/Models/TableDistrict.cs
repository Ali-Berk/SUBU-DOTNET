using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
        public class TableDistrict
        {
            [Key]
            public int DistrictId { get; set; }
            public string DisctrictName { get; set; }
        }
}