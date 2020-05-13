using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class Urun
    {
        // fields 
        private string _Ad;
        private string _Marka;
        private string _Model;
        private string _Ozellik;
        private int _StokAdedi;
        private int _HamFiyat;
        private int _SecilenAdet;

        public static Satis satis = new Satis();

        // properties
        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }

        public string Marka
        {
            get { return _Marka; } 
            set { _Marka = value; }
        }
        public string Model
        {
            get { return _Model; } 
            set { _Model = value; }
        }
        public string Ozellik
        {
            get { return _Ozellik; } 
            set { _Ozellik = value; }
        }
        public int StokAdedi
        {
            get { return _StokAdedi; } 
            set { _StokAdedi = value; }
        }
        public int HamFiyat
        {
            get { return _HamFiyat; } 
            set { _HamFiyat = value; }
        }
        public int SecilenAdet
        {
            get { return _SecilenAdet; } 
            set { _SecilenAdet = value; }
        }

        Random random = new Random(); //stok adedti için random sayılar üretmek için
        
        // constructor
        public Urun(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet)
        {
            _Ad = ad;
            _Marka = marka;
            _Model = model;
            _Ozellik = ozellik;
            System.Threading.Thread.Sleep(15); /* stok miktarının her bir ürüne farklı olması için kullanıldı, eğer kullanılmasaydı her ürün aynı stok miktarına sahip olacaktı*/
            _StokAdedi = random.Next(1, 100); //stok adedine random sayılar atandı.
            _SecilenAdet = secilenAdet;
            _HamFiyat = hamFiyat;
        }

        public Urun()
        {

        }
    }
}
