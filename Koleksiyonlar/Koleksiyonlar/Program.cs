using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlama

            //using.system.collections namespace'i içerisinde bulunurlar.

            #endregion

            #region ArrayList

            //ArrayList liste = new ArrayList();
            //liste.Add(45);
            //liste.Add(85);
            //liste.Add(21);
            //liste.Add(-5);
            //liste.Add(158);
            //liste.Add(15.8);
            ////liste.Add("Mevlüt");

            //Urun u = new Urun();
            //u.Marka = "Faber Castel";
            //u.Model = "Kurşun 0,5";
            //u.Fiyat = 250;

            ////liste.Add(u);

            //liste.AddRange(new int[] { 1, 19, -8, 45, 23, 67, 54 }); //DİZİ EKLEME
            //liste.Insert(2, 96); //2. İNDEXİN YERİNE 96YI ATAR SONRA DİĞERLERİNİ KAYDIRIR -- 2. İNDEXİ SİLMEZ

            //liste.TrimToSize(); //ELEMAN SAYISI KADAR KAPASİTE YAPAR, DOLU OLMAYANLARI SİLİYOR.

            //liste.Add(44); //EKLEME
            //liste.Remove(21); //SİLME
            //liste.Remove(1500);
            //liste.RemoveAt(2); //İNDEX NUMARASINA GÖRE SİLME
            //liste.RemoveRange(2, 3); //2. İNDEXTEN BAŞLA 3 TANE SİL

            //liste.Sort(); //KÜÇÜKTEN BÜYÜĞE SIRALAR
            //liste.Reverse(); //TAM TERSİNE ÇEVİRİR, BÜYÜKTEN KÜÇÜĞE DÖNÜŞTÜ.

            //Console.WriteLine("44 nerede " + liste.IndexOf(44)); //44'ÜN BULUNDUĞU İNDEXİ BULMA
            //Console.WriteLine("1500 nerede " + liste.IndexOf(1500));
            //Console.WriteLine("45 nerede " + liste.LastIndexOf(45)); //SON 45'İN BULUNDUĞU İNDEXİ BULMA
            //liste.Clear(); //KOLEKSİYONU TEMİZLEME


            //Console.WriteLine("Listenin eleman sayısı = " + liste.Count); //ELEMAN SAYISI
            //Console.WriteLine("Listenin kapasitesi = " + liste.Capacity); //KAPASİTE ÖĞRENME



            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}
            #endregion

            #region Urun ile ArrayList

            //ArrayList liste = new ArrayList();
            //Urun u = new Urun();
            //u.Marka = "Faber Castel";
            //u.Model = "Kurşun 0,5";
            //u.Fiyat = 250;
            //liste.Add(u);

            //for (int i = 0; i < liste.Count; i++) //OVERRİDE İLE BASKIN ÇIKARDIĞIMDA 
            //{
            //    Console.WriteLine(liste[i]);
            //}

            #endregion

            #region Dictionary Koleksiyonu

            //Dictionary<string, int> kodlama = new Dictionary<string, int>();
            //kodlama.Add("Araba", 45);
            //kodlama.Add("Sucuk", 13);

            //Console.WriteLine(kodlama["Araba"]);

            #endregion

            #region List <3

            //List<int> sayilar = new List<int>();
            //sayilar.Add(45);
            //sayilar.Add(15);
            //sayilar.Add(158);

            //Console.WriteLine("Eleman sayısı = " + sayilar.Count);
            //Console.WriteLine("Kapasite = " + sayilar.Capacity);

            //bool varmi = sayilar.Contains(15); //İÇERİSİNDE VAR MI DİYE BAKABİLİYORUZ.
            //Console.WriteLine("15 var mı = " + varmi);


            #endregion

            #region Nesne ile koleyksiyon

            List<Urun> urunler = new List<Urun>();

            Urun u = new Urun();
            u.Marka = "Faber Castel";
            u.Model = "Kurşun 0.5";
            u.Fiyat = 250;
            urunler.Add(u);

            urunler.Add(new Urun() { Marka = "Pelikan", Model = "PM08", Fiyat = 52 }); //EKLEME YAPABİLİYORUZ. İNDEX NUMARALARIYLA BAKARIZ.

            //urunler[1].Fiyat = 45;

            bool varmi = urunler.Contains(u);

            for (int i = 0; i < urunler.Count; i++)
            {
                Console.WriteLine(urunler[i].Marka + " " + (urunler[i].Fiyat + 50) ); //OVERRİDE OLMADAN BU ŞEKİLDE YAZARSAK ERİŞEBİLİYORUZ.
            }

            #endregion

        }
    }
}
