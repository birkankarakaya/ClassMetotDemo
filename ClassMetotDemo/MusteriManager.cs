using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
        public void Ekle()
        {
            Console.WriteLine("Ekleme İşlemi Başarılı!\nYeni Kayıt: " + (musteri.Id).ToString() + " " + musteri.Ad);
        }

        public void Sil()
        {
            Console.WriteLine("Kayıt Başarıyla Silindi!");
        }

        public void Guncelle()
        {
            Console.WriteLine("Güncelleme İşlemi Başarılı! " + musteri.Id + " Numaralı Kullanıcı Bilgileri Güncellendi.");
        }
    }
}
