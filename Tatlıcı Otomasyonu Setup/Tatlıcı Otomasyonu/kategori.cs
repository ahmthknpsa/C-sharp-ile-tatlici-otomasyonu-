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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kategori_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into kategori (id,kategori) values ('" + textBox1.Text + "','" + textBox2.Text + "')" ,baglanti);
            komut.ExecuteNonQuery();     // burada sorgumuzu yaptık
            baglanti.Close();            // veritabanımızı kapattık
            label3.Text = textBox2.Text + " kategorisi eklendi ";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
