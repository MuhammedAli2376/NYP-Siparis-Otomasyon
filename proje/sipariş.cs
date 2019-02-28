using System;
using System.IO;

namespace proje
{
    public class sipariş
    {   
        public DateTime tarih { get; set; }
        public string durum { get; set; }
        sipariş_detay siparişDetay = new sipariş_detay();
       // public string[] oku = File.ReadAllLines(@"D:\uygulamalar\HAYSİKİM\yeni\ürünler.txt");
        public int vergi_H(int b)
        {   
            int vergi_yüzdesi = 4;
            int toplam_vergi = 0;
            return toplam_vergi += b * vergi_yüzdesi / 100;
        }       
        public int toplam_Fiyat_H(int c,int d,int e)
        {
            int toplam = 0;
            return toplam += c + d+e;
        }
        public int toplam_agırlık_H(int a)
        {
            int toplam_agırlık = 0;
            int agırlık_bedel = 2;
            toplam_agırlık += a*agırlık_bedel;
            return toplam_agırlık;
        }
    }
}
