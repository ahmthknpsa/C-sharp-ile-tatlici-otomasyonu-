using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatlıcı_Otomasyonu
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yardim = new yardim();
            yardim.Show();
        }

        private void kategoriOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form kategori = new kategori();
            kategori.Show();
        }

        private void anamenu_Load(object sender, EventArgs e)
        {

        }

    

        private void urunTuru_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form urun = new urunTuru();
            urun.Show();
         }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form urunEkle = new urunEkle();
            urunEkle.Show();       // ürün ekleyi göster
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form kullaniciekle = new kullaniciekle();
            kullaniciekle.Show();    
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form musteriEkle = new musteriEkle();
            musteriEkle.Show();
        }

        private void menuEkle_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form menuEkle = new menuekle();
                menuEkle.Show();
        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form menuSil = new menusil();
            menuSil.Show();
            // çalıştırınca menü sil penceresi çalışmış halde olacak
        }

        private void menüGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form menuGuncelle = new menuduzenle();
            menuGuncelle.Show();
            // çalıştırınca menü güncelle penceresi çalışmış halde olacak
        }

        private void aramaYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form aramaYap = new aramayap();
            aramaYap.Show();
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            Form satısYap = new satısyap();
            satısYap.Show();
        }
    }
}
