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

namespace Npd_proje_hasan_berat_söke_b181200046
{
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-AG68N87;Initial Catalog=NDP_proje;Integrated Security=True"); // bağlantı yolu
        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtMail.Text == "" || txtSifre.Text == "" || txtTelfon.Text == "" || txtAdres.Text == "") // text alanlarının boş olmasını engellemek için yaptım.
            {
                txtAd.BackColor = Color.Red;
                txtSoyad.BackColor = Color.Red;
                txtMail.BackColor = Color.Red;
                txtSifre.BackColor = Color.Red;
                txtTelfon.BackColor = Color.Red;
                txtAdres.BackColor = Color.Red;

                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
            else
            {
                connection.Open();

                SqlCommand komut =
                    new SqlCommand(
                        "insert into Tbl_Login (ad,soyad,mail,sifre,telefon,adres)values (@p1,@p2,@p3,@p4,@p5,@p6)",
                        connection);

                komut.Parameters.AddWithValue("@p1",
                    txtAd.Text);                               //insert into sorgusunu kullanarak parametleri tabloya ekledim.
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtMail.Text);
                komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                komut.Parameters.AddWithValue("@p5", txtTelfon.Text);
                komut.Parameters.AddWithValue("@p6", txtAdres.Text);

                komut.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Üyeliğiniz başarılı bir şekilde oluşturulmuştur.");
                this.Hide();

                giris_ekrani giris = new giris_ekrani();
                giris.Show();
            }
        }
    }
}
