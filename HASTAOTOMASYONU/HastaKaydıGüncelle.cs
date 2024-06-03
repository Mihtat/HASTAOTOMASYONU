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
    public partial class HastaKaydıGüncelle : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;
        public HastaKaydıGüncelle()
        {
            InitializeComponent();
        }

        void listele()
        {
            baglanti = new SqlConnection("server=DESKTOP-G1KASPD;Initial Catalog=HASTABİLGİVT;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM HASTABİLGİVT", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaBilgiListele form = new HastaBilgiListele();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaKaydıYap form = new HastaKaydıYap();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Anasayfa form = new Anasayfa();
            form.Show();
            this.Hide();
        }

        private void HastaKaydıGüncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=DESKTOP-G1KASPD;Initial Catalog=HASTABİLGİVT;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM HASTABİLGİVT where Adı like'" + textBox2.Text + "%'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string sorgu = "DELETE FROM HASTABİLGİVT WHERE ID=@ID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                MessageBox.Show("Hasta Çıkışı Gerçekleşti", "Hasta Çıkışı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                string sorgu = "UPDATE HASTABİLGİVT SET adı=@adı,soyadı=@soyadı,TCPass=@TCPass,Poliklink=@Poliklink WHERE ID=@ID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ID", textBox1.Text);
                komut.Parameters.AddWithValue("@Adı", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyadı", textBox3.Text);
                komut.Parameters.AddWithValue("@TCPass", textBox4.Text);
                komut.Parameters.AddWithValue("@Poliklink", textBox5.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                MessageBox.Show("Hasta Bilgisi Başarıyla Güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }

}
