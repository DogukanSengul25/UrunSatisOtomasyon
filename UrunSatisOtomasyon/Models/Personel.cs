using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunSatisOtomasyon.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Display(Name = "Personel Adı")]
        [Required(ErrorMessage = "Personel Adı Giriniz", AllowEmptyStrings = false)]
        public string Ad { get; set; }

        [Display(Name = "Personel Soyadı")]
        [Required(ErrorMessage = "Personel Soyadı Giriniz", AllowEmptyStrings = false)]
        public string Soyad { get; set; }

        [Display(Name = "Personel Numarası ")]
        [Required(ErrorMessage = "Personel Numarası Giriniz", AllowEmptyStrings = false)]
        public string Numara { get; set; }

        [Display(Name = "Personel Tc")]
        [Required(ErrorMessage = "Personel Tc Giriniz", AllowEmptyStrings = false)]
        public string Tc { get; set; }


    }
}