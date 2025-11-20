using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
    public class TableUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "E-Mail'inizi Giriniz")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir E-Mail adresi giriniz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrenizi Giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int RoleID { get; set; }

        public virtual TableRoles Role { get; set; }




    }
}