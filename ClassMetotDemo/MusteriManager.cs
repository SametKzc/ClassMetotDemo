using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void  MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Bilgileri Eklendi : " + musteri.Ad + " " + musteri.Soyad);
        } 
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Listelendi : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bigileri Silindi: " + musteri.Id); 
        }
    }
}
