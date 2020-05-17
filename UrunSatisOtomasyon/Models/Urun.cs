using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunSatisOtomasyon.Models
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Display(Name = "Urun Marka")]
        [Required(ErrorMessage = "Ürün Marka Giriniz", AllowEmptyStrings = false)]
        public string UrunMarka { get; set; }

        [Display(Name = "Urun Model")]
        [Required(ErrorMessage = "Ürün Modelini Giriniz", AllowEmptyStrings = false)]
        public string UrunModel { get; set; }

        [Display(Name = "Urun Kategori")]
        [Required(ErrorMessage = "Ürün Kategorisini Giriniz", AllowEmptyStrings = false)]
        public string UrunKategori { get; set; }

        [Display(Name = "Urun Fiyat")]
        [Required(ErrorMessage = "Ürün Fiyatını Giriniz", AllowEmptyStrings = false)]
        public int UrunFiyat { get; set; }

        [Display(Name = "Urun Kod")]
        [Required(ErrorMessage = "Ürün Kodunu Giriniz", AllowEmptyStrings = false)]
        public string UrunKod { get; set; }
    }
}