using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLNedir
{
    public class XmlIslemleri
    {
        string FilePath;
        public XmlIslemleri(string path)
        {
            FilePath = path;
        }
        public void Olustur()
        {
            StreamWriter fs = new StreamWriter(FilePath);
            //string Initial = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"+Environment.NewLine + "<Personeller>" + Environment.NewLine + "</personeller>";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<Personeller>");
            sb.AppendLine("</Personeller>");
            fs.WriteLine(sb.ToString());
            fs.Close();
        }

        public void Oku()
        {
            XDocument doc = XDocument.Load(FilePath);
            XElement root = doc.Root;
            string ID, isim, soyad, telefon;
            foreach (XElement item in root.Elements())
            {
                ID = item.Attribute("id").Value;
                isim = item.Element("isim").Value;
                soyad = item.Element("soyisim").Value;
                telefon = item.Element("telefon").Value;
                string telefoncode = telefon.Substring(0, 7) + "****";
                Console.WriteLine($"ID= {ID}\nIsim={isim}\nSoyad={soyad}\nTelefon={telefoncode}");
            }
        }

        public void Ekle(string id, string isim, string soyad, string telefon)
        {
            XDocument doc = XDocument.Load(FilePath);
            XElement root = doc.Root;
            XElement yeni = new XElement("Personel");
            XAttribute idAttribute = new XAttribute("id", id);
            XElement isimelement = new XElement("isim", isim);
            XElement soyisimelement = new XElement("soyisim", soyad);
            XElement telefonelement = new XElement("telefon", telefon);
            yeni.Add(idAttribute, isimelement, soyisimelement, telefonelement);
            root.Add(yeni);
            doc.Save(FilePath);
        }
    }
}
