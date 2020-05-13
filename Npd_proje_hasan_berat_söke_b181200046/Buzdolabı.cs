using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npd_proje_hasan_berat_söke_b181200046.Satis;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    class Buzdolabı:Urun
    {
        // fields
        private int _Ichacim;
        private string _EnerjiSinifi;
        
        // properties
        public int Ichacim
        {
            get { return _Ichacim; }
            set { _Ichacim = value; }
        }

        public string EnerjiSinifi
        {
            get { return _EnerjiSinifi; }
            set { _EnerjiSinifi = value; }
        }
        // constractor
        public Buzdolabı(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenAdet, int ıchacim, string enerjisinifi)
            : base(ad,marka,model,ozellik,hamFiyat,secilenAdet)// base kullanılarak urun sınıfındaki üyelere ulaşıldı.
        {
            _Ichacim = ıchacim;
            _EnerjiSinifi = enerjisinifi;
        }

        public Buzdolabı(int hamfiyat)
        {
            this.HamFiyat = hamfiyat;
        }
        // method
        public double KdvUygula ()
        {
            double KdvBedeli = HamFiyat * Convert.ToInt32(frm.nmcAdetBuzdolabı.Value) * (1.35);
            return KdvBedeli;
        }
    }
}
