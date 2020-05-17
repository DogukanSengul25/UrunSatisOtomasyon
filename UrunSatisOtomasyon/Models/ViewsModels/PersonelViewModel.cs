using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrunSatisOtomasyon.Models.ViewsModels
{
    public class PersonelViewModel
    {
        public Personel Per { get; set; }
        public IEnumerable<Personel> Personeler { get; set; }
    }
}