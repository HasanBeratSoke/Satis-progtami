using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class BulasikMakinesi:Urun
    {
        //fields
        private string _EnerjiSinifi;
        private int _Ichacim;

        // properties
        public string EnerjiSinifi
        {
            get { return _EnerjiSinifi; }
            set { _EnerjiSinifi = value; }
        }

        public int Ichacim
        {
            get { return _Ichacim; }
            set { _Ichacim = value; }
        }

        //kurucular

        public BulasikMakinesi(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet,
            string enerjisinifi, int ıchacim) : base(ad, marka, model, ozellik, hamFiyat, secilenAdet)
        {
            _EnerjiSinifi = enerjisinifi;
            _Ichacim = ıchacim;
        }

        public BulasikMakinesi(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;
        }

        // method
        public double KdvUygula ()
        {
            double KdvbulaşıkBed = HamFiyat * Convert.ToInt32(frm.nmcAdetBulaşık.Value) * (1.15);
            return KdvbulaşıkBed;
        }

    }
}
