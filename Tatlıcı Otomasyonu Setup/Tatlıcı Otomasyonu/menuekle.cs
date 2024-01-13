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
    public partial class menuekle : Form
    {
        public menuekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
        private void menuekle_Load(object sender, EventArgs e)
        {
            //comboboxa kategori alma 
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select kategori from kategori", baglanti);  // kategoriyi gösterdik kategori tablosundan
            OleDbDataReader oku = komut.ExecuteReader();         // veri tabanındaki verileri okuduk
            while(oku.Read())      // komut okuyorken
            {
                comboBox1.Items.Add(oku["kategori".ToString()]);  // oku komutunda bulduğun kategori sütünlarını ekle
             }
            baglanti.Close();

            //comboboxa ürün türü alma 
            baglanti.Open();
            OleDbCommand komutUrunTuru = new OleDbCommand("select urunturuekle from urunturuekle", baglanti);  // kategoriyi gösterdik kategori tablosundan
            OleDbDataReader okuUrunTuru = komutUrunTuru.ExecuteReader();         // veri tabanındaki verileri okuduk
            while (okuUrunTuru.Read())      // komut okuyorken
            {
                comboBox2.Items.Add(okuUrunTuru["urunturuekle".ToString()]);  // oku komutunda bulduğun kategori sütünlarını ekle
            }
            baglanti.Close();

            //comboboxa ürün alma 
            baglanti.Open();
            OleDbCommand komutUrun = new OleDbCommand("select urun from urunekle", baglanti);  
            OleDbDataReader okuUrun = komutUrun.ExecuteReader();         // veri tabanındaki verileri okuduk
            while (okuUrun.Read())      // komut okuyorken
            {
                comboBox3.Items.Add(okuUrun["urun".ToString()]);  
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into menu (barkodno,kategori,urunturu,urun,fiyati,masano,adet,gtarihi) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            label9.Text = "Menü başarıyla eklendi";
            textBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
           
            baglanti.Close();
            menuekle_Load(sender, e);
        }
    }
}
