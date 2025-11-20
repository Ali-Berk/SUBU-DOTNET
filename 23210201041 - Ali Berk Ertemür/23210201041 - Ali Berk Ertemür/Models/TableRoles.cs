using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
    public class TableRoles
    {
        [Key]
        public int RoleId { get; set; }
        public string Role { get; set; }

        public List<TableUser> Users { get; set; }


    }
}