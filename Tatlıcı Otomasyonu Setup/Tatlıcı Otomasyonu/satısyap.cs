using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tatlıcı_Otomasyonu
{
    public partial class satısyap : Form
    {
        public satısyap()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
        DataTable tablo = new DataTable();

        private void SatışListesi(string sorgu, OleDbConnection baglanti)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void satısyap_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SatışListesi("select*from menu where barkodno like '" + textBox6.Text + "'", baglanti);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMusteri_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from menu where barkodno like '" + textBox6.Text + "'", baglanti); // müşteride adı textbox1 gibi olduğu yerleri seç getir
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void SatışListesi(string v)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox12.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from musteri where soyad='" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();          // oku komutunu verdik
            while (oku.Read())
            {
                textBox2.Text = oku["telefon"].ToString();
                textBox3.Text = oku["eposta"].ToString();
            }
            baglanti.Close();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from menu where barkodno='" + textBox6.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();          // oku komutunu verdik
            while (oku.Read())
            {
                textBox5.Text = oku["kategori"].ToString();
                textBox4.Text = oku["urunturu"].ToString();
                textBox8.Text = oku["urun"].ToString();
                textBox7.Text = oku["fiyati"].ToString();
                textBox9.Text = oku["adet"].ToString();
                textBox12.Text = oku["gtarihi"].ToString();
            }
            baglanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)    // TOPLAM TUTAR
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

