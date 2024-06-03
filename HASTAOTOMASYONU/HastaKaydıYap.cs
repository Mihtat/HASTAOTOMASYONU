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

namespace HASTAOTOMASYONU
{
    public partial class HastaKaydıYap : Form
    {
        public HastaKaydıYap()
        {
            InitializeComponent();
        }

        private void KAYITYAP_Click(object sender, EventArgs e)
        {
            DialogResult onay;
            onay = MessageBox.Show("Hasta Kaydı Yapılsın mı ?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1KASPD; initial catalog = HASTABİLGİVT; integrated security = True ");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into HASTABİLGİVT (Adı, Soyadı, TCPass, Poliklink) VALUES (@Adı, @Soyadı, @TCPass, @Poliklink)", baglanti);
                komut.Parameters.AddWithValue("@Adı", AD.Text);
                komut.Parameters.AddWithValue("@Soyadı", SOYAD.Text);
                komut.Parameters.AddWithValue("@TCPass", TCPASPORT.Text);
                komut.Parameters.AddWithValue("@Poliklink", POLİKLİNİK.Text);
                komut.ExecuteNonQuery();//komutu çalıştır verileri ekle
                baglanti.Close();
                MessageBox.Show("Hasta Kaydı Yapıldı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void AD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SOYAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TCPASPORT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void POLİKLİNİK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
