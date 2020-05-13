using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Npd_proje_hasan_berat_söke_b181200046
{
    public partial class Satis : Form
    {
        // form elemanlarına her yerden ulaşılabilmesi için tanımladım.
        public static Satis frm;
        public Satis()
        {
            InitializeComponent();

            // form elemanlarına her yerden ulaşabilmesi için tanımladım.
            frm = this;
        }

        // sınıfların nesnelerini oluşturdum

        Buzdolabı buzdolabı = new Buzdolabı("Buzdolabı", "vestel", "fsfs", "rrffw", 3500, 0, 23, "wqe");
        BulasikMakinesi bulasikMakinesi = new BulasikMakinesi("Bulaşık makinesi", "asd", "asd", "asd", 2500, 0, "asd", 200);
        CamasirMakinesi camasirMakinesi = new CamasirMakinesi("Camaşır makinesi", "asd", "asd", "asd", 3000, 0, 10, "asd");
        KurutmaMakinesi kurutmaMakinesi = new KurutmaMakinesi("Kurutma makinesi", "asd", "asd", "asd", 4000, 0, 5, "asd");
        Ceptel ceptel = new Ceptel("Cep telefonu", "asd", "asd", "asd", 2500, 0, 64, 8, 2500);
        Laptop laptop = new Laptop("Laptop", "asd", "asd", "asd", 6000, 0, 1980, 2050, 500, 32, 6000);
        AkıllıSaat akıllıSaat = new AkıllıSaat("Akıllı saat", "asd", "asd", "asd", 1000, 0, 4, 1000);


        Buzdolabı buzdolabıkdv = new Buzdolabı(3500);
        BulasikMakinesi bulasikMakinesikdv = new BulasikMakinesi(2500);
        CamasirMakinesi camasirMakinesikdv = new CamasirMakinesi(3000);
        KurutmaMakinesi kurutmaMakinesikdv = new KurutmaMakinesi(4000);
        Ceptel ceptelkdv = new Ceptel(2500);
        Laptop laptopkdv = new Laptop(6000);
        AkıllıSaat saatkdv = new AkıllıSaat(1000);

        public int toplam; // global değişken tanımladım

        private void Satis_Load(object sender, EventArgs e)
        {
            // nesnelerin ham fiyatlarını formda göstermek istedim.
            lblFiyatBuz.Text = Convert.ToString(buzdolabı.HamFiyat + "TL");
            lblFiyatBulaşık.Text = Convert.ToString(bulasikMakinesi.HamFiyat + "TL");
            lblFiyatCamasır.Text = Convert.ToString(camasirMakinesi.HamFiyat + "TL");
            lblFiyatKurutma.Text = Convert.ToString(kurutmaMakinesi.HamFiyat + "TL");
            lblFiyatCeptel.Text = Convert.ToString(ceptel.HamFiyat + "TL");
            lblFiyatLaptop.Text = Convert.ToString(laptop.HamFiyat + "TL");
            lblFiyatSaat.Text = Convert.ToString(akıllıSaat.HamFiyat + "TL");

            //Stok miktarların aktarılması
            lblStokBuz.Text = Convert.ToString(buzdolabı.StokAdedi);
            lblStokBulaşık.Text = Convert.ToString(bulasikMakinesi.StokAdedi);
            lblStokCamasır.Text = Convert.ToString(camasirMakinesi.StokAdedi);
            lblStokKurutma.Text = Convert.ToString(kurutmaMakinesi.StokAdedi);
            lblStokCeptel.Text = Convert.ToString(ceptel.StokAdedi);
            lblStokLaptop.Text = Convert.ToString(laptop.StokAdedi);
            lblStokSaat.Text = Convert.ToString(akıllıSaat.StokAdedi);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
        private void btnEkleBuzdolabı_Click(object sender, EventArgs e)
        {
            // numeric 0 olmasına  eklemesine karşı if koşulunu kullandım. 
            if (nmcAdetBuzdolabı.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetBuzdolabı.Value));// sepete eklene nesnenin değerlerini listboxda gözükmesini sağlıyorum.
                listÜrün.Items.Add(Convert.ToString(buzdolabı.Ad));
                listKdvsiz.Items.Add(Convert.ToString(buzdolabıkdv.KdvUygula()));
                lblStokBuz.Text = Convert.ToString((buzdolabı.StokAdedi) - (nmcAdetBuzdolabı.Value));// anlık stokdan satın alınan miktar kadar düşürülüyor
            }
            toplam = Convert.ToInt32(lblToplamTutar.Text) + Convert.ToInt32(buzdolabıkdv.KdvUygula());// kdvli fiyatları, toplam fiyatlara ekleme işlemi.
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnEkleBulaşık_Click(object sender, EventArgs e)
        {

            if (nmcAdetBulaşık.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetBulaşık.Value));
                listÜrün.Items.Add(Convert.ToString(bulasikMakinesi.Ad));
                listKdvsiz.Items.Add(Convert.ToString(bulasikMakinesikdv.KdvUygula()));
                lblStokBulaşık.Text = Convert.ToString((bulasikMakinesi.StokAdedi) - (nmcAdetBulaşık.Value));
            }

            toplam = toplam + Convert.ToInt32(bulasikMakinesikdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);

        }

        private void btnEkleCamasır_Click(object sender, EventArgs e)
        {

            if (nmcAdetCamasır.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetCamasır.Value));
                listÜrün.Items.Add(Convert.ToString(camasirMakinesi.Ad));
                listKdvsiz.Items.Add(Convert.ToString(camasirMakinesikdv.KdvUygula()));
                lblStokCamasır.Text = Convert.ToString((camasirMakinesi.StokAdedi) - (nmcAdetCamasır.Value));

            }
            toplam = toplam + Convert.ToInt32(camasirMakinesikdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnEkleKurutma_Click(object sender, EventArgs e)
        {

            if (nmcAdetKurutma.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetKurutma.Value));
                listÜrün.Items.Add(Convert.ToString(kurutmaMakinesi.Ad));
                listKdvsiz.Items.Add(Convert.ToString(kurutmaMakinesikdv.KdvUygula()));
                lblStokKurutma.Text = Convert.ToString((kurutmaMakinesi.StokAdedi) - (nmcAdetKurutma.Value));
            }
            toplam = toplam + Convert.ToInt32(kurutmaMakinesikdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnEkleCeptel_Click(object sender, EventArgs e)
        {
            if (nmcAdetCeptel.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetCeptel.Value));
                listÜrün.Items.Add(Convert.ToString(ceptel.Ad));
                listKdvsiz.Items.Add(ceptelkdv.KdvUygula());
                lblStokCeptel.Text = Convert.ToString((ceptel.StokAdedi) - (nmcAdetCeptel.Value));
            }
            toplam = toplam + Convert.ToInt32(ceptelkdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnEkleLaptop_Click(object sender, EventArgs e)
        {
            if (nmcAdetLaptop.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetLaptop.Value));
                listÜrün.Items.Add(Convert.ToString(laptop.Ad));
                listKdvsiz.Items.Add(laptopkdv.KdvUygula());
                lblStokCeptel.Text = Convert.ToString((laptop.StokAdedi) - (nmcAdetLaptop.Value));
            }
            toplam = toplam + Convert.ToInt32(laptopkdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnEkleSaat_Click(object sender, EventArgs e)
        {
            if (nmcAdetSaat.Value != 0)
            {
                listAdet.Items.Add(Convert.ToString(nmcAdetSaat.Value));
                listÜrün.Items.Add(Convert.ToString(akıllıSaat.Ad));
                listKdvsiz.Items.Add(saatkdv.KdvUygula());
                lblStokSaat.Text = Convert.ToString((akıllıSaat.StokAdedi) - (nmcAdetSaat.Value));
            }
            toplam = toplam + Convert.ToInt32(saatkdv.KdvUygula());
            lblToplamTutar.Text = Convert.ToString(toplam);
        }

        private void btnKupon_Click(object sender, EventArgs e)
        {
            int sonuc = 0; // toplam fiyata göre indirim uygulama
            if (7000>toplam)
            {
                 sonuc = toplam / 5;
                 toplam = toplam - sonuc;
                 lblIskonto.Text = Convert.ToString(5);

            }
            else
            {
                sonuc = toplam / 7;
                toplam = toplam - sonuc;
                lblIskonto.Text = Convert.ToString(7);
            }

            lblToplamTutar.Text = Convert.ToString(toplam);

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın Alma İşleminiz Gerçekleşti, İyi günlerde kullanın :)");
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listAdet.Items.Clear(); //listeleri temizleme işlemi
            listÜrün.Items.Clear();
            listKdvsiz.Items.Clear();
            lblToplamTutar.Text = Convert.ToString(0);

        }
    }
}
