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
    public partial class HastaBilgiListele : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        public HastaBilgiListele()
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HastaKaydıGüncelle form = new HastaKaydıGüncelle();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listele();
        }

        private void HastaBilgiListele_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
