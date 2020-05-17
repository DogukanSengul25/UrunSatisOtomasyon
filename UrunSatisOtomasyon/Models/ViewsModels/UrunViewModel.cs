using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UrunSatisOtomasyon.Models.ViewsModels
{
    public class UrunViewModel
    {
        public Urun urn { get; set; }
        public IEnumerable<Urun> Urunler { get; set; }
    }
}