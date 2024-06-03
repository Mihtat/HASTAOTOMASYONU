using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTAOTOMASYONU
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici.Text == "" || sifre.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılmaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (kullanici.Text == "mihtat" && sifre.Text == "mihtat123")
                {
                    Anasayfa form = new Anasayfa();
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı'nız veya Şifreniz yanlış lütfen Kontroller doğrultusunda tekrar deneyiniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult onay = MessageBox.Show("Eminmisiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
