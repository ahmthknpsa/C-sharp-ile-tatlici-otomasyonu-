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
    public partial class menuduzenle : Form
    {
        public menuduzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
        private void menuduzenle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from menu where barkodno='"+textBox1.Text+"'",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();          // oku komutunu verdik
            while (oku.Read())
            {
                comboBox1.Text = oku["kategori"].ToString();
                comboBox2.Text = oku["urunturu"].ToString();
                comboBox3.Text = oku["urun"].ToString();
                textBox5.Text = oku["fiyati"].ToString();
                textBox6.Text = oku["masano"].ToString();
                textBox7.Text = oku["adet"].ToString();
                dateTimePicker1.Text = oku["gtarihi"].ToString();
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update menu set barkodno='" + textBox1.Text + "',kategori='" + comboBox1.Text + "', urunturu='" + comboBox2.Text + "', urun='" + comboBox3.Text + "', fiyati='" + textBox5.Text + "', masano='" + textBox6.Text + "', adet='" + textBox7.Text + "', gtarihi='" + dateTimePicker1.Text + "'where barkodno='"+textBox1.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            label9.Text = textBox1.Text + " barkod nolu ürününüz başarıyla güncellendi ";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
