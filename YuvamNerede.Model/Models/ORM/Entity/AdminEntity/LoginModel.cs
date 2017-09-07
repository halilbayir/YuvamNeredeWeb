using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuvamNerede.Model.Models.ORM.Entity.AdminEntity
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen email adresini doldurunuz")]
        [EmailAddress(ErrorMessage = "Düzgün bir email adresi giriniz")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Lütfen parola kısmını doldurunuz")]
        public string Password { get; set; }
    }
}
