using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/******************************************************************************
 *              T.C SAKARYA ÜNİVERSİTESİ
 *          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 *               BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
 *              NESNEYE DAYALI PROGLAMLAMA DERSİ
 *                  2019-2020 BAHAR DÖNEMİ
 *                    
 *  PROJE NUMARASI: 01
 *  ÖĞRENCİNİN ADI: HASAN BERAT SÖKE
 *  NUMARASI:       B181200046
 *  DERSİN HOCASI:  ÖĞR.GÖR.DR. SELMAN HIZAL
 *  DERSİ ALDIĞI GRUP: A
 *
 *
 ******************************************************************************/

namespace Npd_proje_hasan_berat_söke_b181200046
{
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=NDP_proje;Integrated Security=True"); // bağlantı yolu

        private void giris_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "Select * From Tbl_Login where mail=@p1 AND sifre=@p2";
                SqlParameter prm1 = new SqlParameter("p1",kullanici_adi_txt.Text.Trim()); // trim fonfsiyonu boşlukları siliyorum.
                SqlParameter prm2 = new SqlParameter("p2",sifre_txt.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,connection); // sorguyla bağlantıyı ilişkilendirdim.
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();// veritabanından select ile cektiğimiz verileri dt de tutabiliriz
                SqlDataAdapter da = new SqlDataAdapter(komut); //bağlanılan veritabanında calışılıcak sorguyu tanımlar.
                da.Fill(dt);// veriler dt tablosuna doldurulur.

                if (dt.Rows.Count>0)
                {
                    this.Hide(); // yeni forum acılıcak
                    Satis satis = new Satis();
                    satis.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş! Lütfen Tekrar Deneyiniz.");

            }
        }

        private void linkLabelÜyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
            this.Hide();
        }
       
        
    }
}
