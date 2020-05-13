using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class Ceptel:Urun
    {
        // fields
        private int _DahiliHafıza;
        private int _RamMiktarı;
        private int _PilGücü;

        //properties
        public int DahiliHafıza
        {
            get { return _DahiliHafıza; }
            set { _DahiliHafıza = value; }
        }

        public int RamMiktar
        {
            get { return _RamMiktarı;}
            set { _RamMiktarı = value;}
        }

        public int PilGücü
        {
            get { return _PilGücü;}
            set { _PilGücü = value;}
        }

        // constractor
        public Ceptel(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet,
            int dahiliHafıza, int ramMiktarı, int pilGücü) : base(ad, marka, model, ozellik, hamFiyat, secilenAdet)// miras aldığımız sınıfın özelliklerine olaşmak için base kullandım.
        {

        }

        public Ceptel(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;
        }
        
        // method
        public double KdvUygula()
        {
            double KdvCeptel = HamFiyat * Convert.ToInt32(frm.nmcAdetCeptel.Value) * (1.20);
            return KdvCeptel;
        }
    }
}
