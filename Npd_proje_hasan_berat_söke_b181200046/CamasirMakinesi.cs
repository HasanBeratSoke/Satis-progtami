using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;// formdaki elemanlara ulaşabilmek için ekledim

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class CamasirMakinesi: Urun
    {
        // fields
        private int _IcHacim;
        private string _EnerjiSinifi;

        public int IcHacim
        {
            get { return _IcHacim; }
            set { _IcHacim = value; }
        }

        public string EnerjiSinifi
        {
            get { return _EnerjiSinifi; }
            set { _EnerjiSinifi = value; }
        }
        
        //kurucu methodlar
        public CamasirMakinesi(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet,
            int ıchacim, string enerjisinifi) : base(ad, marka, model, ozellik, hamFiyat, secilenAdet)
        {
            _IcHacim = ıchacim;
            _EnerjiSinifi = enerjisinifi;
        }

        public CamasirMakinesi(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;
        }
        
        // method
        public double KdvUygula()
        {
            double kdvcamasir = HamFiyat * Convert.ToInt32(frm.nmcAdetCamasır.Value) * (1.15);
            return kdvcamasir;
        }
    }
}
