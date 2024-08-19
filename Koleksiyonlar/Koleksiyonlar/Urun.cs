using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Urun
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        public override string ToString() 
        {
            return "Marka = " + Marka + " Model = " + Model + " Fiyat = " + Fiyat + " TL";
        }

    }
}
