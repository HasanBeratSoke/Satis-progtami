using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class AkıllıSaat : Urun
    {
        // fields
        private int _PilGucu;
        private int _RamKapasitesi;

        public int PilGucu
        {
            get { return _PilGucu; }
            set { _PilGucu = value; }
        }

        public int RamKapasitesi
        {
            get { return _RamKapasitesi; }
            set { _PilGucu = value; }
        }

        // kurucu methodlar
        public AkıllıSaat(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet,
            int ramkapasitesi, int pilgücü) : base(ad, marka, model, ozellik, hamFiyat, secilenAdet)
        {

        }

        public AkıllıSaat(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;
        }

        //method
        public double KdvUygula()
        {
            double kdvsaat = HamFiyat * Convert.ToInt32(frm.nmcAdetSaat.Value) * (1.50);
            return kdvsaat;
        }
    }
}
