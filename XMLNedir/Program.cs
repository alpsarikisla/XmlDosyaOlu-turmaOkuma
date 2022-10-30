using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Türkçe açılımı Genişletilebilir işaretleme dili anlamına gelen XML(Extensible Markup Language), bilgi işlem sistemleri için kolayca okunabilecek veri dökümenları yani veri tabanı oluşturmaya yarayan, W3C tarafından tanımlanmış bir standarttır. 
            //Veri saklama görevinin yanısıra daha çok kullanılan alanı farklı sistemlerde(Farklı platformlar ve farklı diller) oluşturulmuş programlar arasında veri alışverişi konusunda entegrasyon görevi üstlenir.

            #endregion

            XmlIslemleri xi = new XmlIslemleri("Personeller.xml");

            #region XML Dosyası Oluşturma

            //xi.Olustur();

            #endregion

            #region XML Okuma

            //xi.Oku();

            #endregion

            #region XML Ekleme

            Console.Write("ID = ");
            string id = Console.ReadLine();
            Console.Write("İsim = ");
            string isim = Console.ReadLine();
            Console.Write("Soyad = ");
            string soyad = Console.ReadLine();
            Console.Write("Telefon = ");
            string telefon = Console.ReadLine();

            xi.Ekle(id, isim, soyad, telefon);
            xi.Oku();

            #endregion
        }
    }
}
