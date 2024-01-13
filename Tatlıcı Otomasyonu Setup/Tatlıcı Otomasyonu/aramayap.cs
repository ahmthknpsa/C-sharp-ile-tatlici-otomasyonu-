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
    public partial class aramayap : Form
    {
        public aramayap()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
        DataTable musteriTablosu = new DataTable();
        DataTable menuTablosu = new DataTable();
        private void aramayap_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Müşteri")
            {
                baglanti.Open();
                musteriTablosu.Clear();
                OleDbDataAdapter musteriAdapter = new OleDbDataAdapter("select * from musteri", baglanti);    // müşteriden adaptör aldık
                musteriAdapter.Fill(musteriTablosu);       // bunu doldur
                dataGridView1.DataSource = musteriTablosu;         // veri tabanını tabloya eşitledik
                baglanti.Close();
                    }
            else if (comboBox1.Text=="Menü")
            {
                baglanti.Open();
               menuTablosu.Clear();
                OleDbDataAdapter menuAdapter = new OleDbDataAdapter("select*from menu", baglanti);
                menuAdapter.Fill(menuTablosu);
                dataGridView1.DataSource = menuTablosu;
                baglanti.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Müşteri")
            {
                baglanti.Open();
                musteriTablosu.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from musteri where ad like '" + textBox1.Text + "'", baglanti); // müşteride adı textbox1 gibi olduğu yerleri seç getir
                adapter.Fill(musteriTablosu);
                dataGridView1.DataSource = musteriTablosu;
                baglanti.Close();
            }
            else if(comboBox1.Text == "Menü")
            {
                baglanti.Open();
                menuTablosu.Clear();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from menu where barkodno like '" + textBox1.Text + "'", baglanti); // müşteride adı textbox1 gibi olduğu yerleri seç getir
                adapter.Fill(menuTablosu);
                dataGridView1.DataSource = menuTablosu;
                baglanti.Close();
            }
        }
    }
}
