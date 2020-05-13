using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class Laptop:Urun
    {
        //fields

        private int _EkranBoyutu;
        private int _EkranCozunurluk;
        private int _DahiliHafıza;
        private int _RamKapasitesi;
        private int _PilGucu;

        //properties

        public int EkranBoyutu
        {
            get { return _EkranBoyutu; }
            set { _EkranBoyutu = value; }
        }

        public int EkranCozunurluk  
        {
            get { return _EkranCozunurluk; }
            set { _EkranCozunurluk = value; }
        }

        public int DahiliHafıza
        {
            get { return _DahiliHafıza; }
            set { _DahiliHafıza = value; }
        }

        public int RamKapasitesi
        {
            get { return _RamKapasitesi; }
            set { _RamKapasitesi = value; }
        }

        public int PilGucu
        {
            get { return _PilGucu; }
            set { _PilGucu = value; }
        }

        // kurucu methodlar
        public Laptop(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet,
            int ekranboyutu, int ekrancozunurlugu,int dahiliHafıza,int ramKapasitesi, int pilGucu) : base(ad, marka, model, ozellik, hamFiyat, secilenAdet)
        {
            _EkranBoyutu = ekranboyutu;
            _EkranCozunurluk = ekrancozunurlugu;
            _DahiliHafıza = dahiliHafıza;
            _RamKapasitesi = ramKapasitesi;
            _PilGucu = pilGucu;
        }

        public Laptop(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;

        }
        //method
        public double KdvUygula()
        {
            double kdvlaptop = HamFiyat * Convert.ToInt32(frm.nmcAdetLaptop.Value) * (1.50);
            return kdvlaptop;
        }

    }
}
