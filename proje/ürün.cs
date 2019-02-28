using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class ürün
    {
        public string fiyat { get; set; }
        public string kargo_agırlık { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string stok { get; set; }
        public List<ürün> ürünler = new List<ürün>();
        public void ürün_ekle(ürün ü )
        {
            ürünler.Add(ü);
        }
        string listele = "";
        public string ürün_listele()
        {
            foreach(ürün a in ürünler)
            {
                listele = "ürün marka: " +a.marka+ "  ürün model: " + a.model +"ürün fiyatı:" + a.fiyat+"ürün stok:"+a.stok+" ürün agırlık:"+a.kargo_agırlık +Environment.NewLine;
            }
            return listele;
        }   
        /*
        public int miktar_başı_H()
        {
            return
        }
        public int agırlık_H()
        {
            return
        }
        */
    }
}
