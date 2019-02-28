using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class kredi_kartı:ödeme_sınıf
    {
        public int no { get; set; }
        public string tip { get; set; }
        public int son_kullanma_T { get; set; }
        public string yetkili(int n,string t,int s)
        { string test = "olumsuz";
            no = 789;
            tip = "maxkart";
            son_kullanma_T = 2024;
            if (n==no&&t==tip&&s==son_kullanma_T)
            {
                test = "olumlu";
            }
            return test;
        }
    }
}
