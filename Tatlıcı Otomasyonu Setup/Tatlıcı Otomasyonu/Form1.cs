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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ahmet\\Documents\\TatlıcıOtomasyonu.mdb");  // burada bir veritabanı açtık.
   

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
               
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void btnGiris_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from kullanicibilgileri where kullaniciadi = '" + textBox1.Text + "' ", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read() == true)
                { 
                    if (textBox1.Text == oku["kullaniciadi"].ToString() && textBox2.Text == oku["sifre"].ToString())      // eğer doğru ise yeni form sayfasına yönlendirecek.
                    {
                        MessageBox.Show("Hoşgeldiniz Sayın " + oku["adısoyadı"].ToString());
                        Form form = new anamenu();
                        form.Show();                      // yeni form sayfasını aç.
                        this.Hide();                     // bunu da saklasın anlamına gelir.
                    }
                    else
                    {
                        MessageBox.Show("Giriş Bilgileriniz Yanlış, Lütfen Tekrar Deneyiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Giriş Bilgileriniz Yanlış, Lütfen Tekrar Deneyiniz!");
                }
                baglanti.Close();               //  açtığımız veritabanını geri kapattık

                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Increment(25);
        }
    }
}
