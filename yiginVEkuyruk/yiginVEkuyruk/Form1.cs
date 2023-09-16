using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yiginVEkuyruk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class dugum
        {
            public int sayi;
            public dugum baglanti;
        }
        dugum ilk_yigin_dugum;
        dugum on_kuyruk, arka_kuyruk;
        private void btn_yigin_ekle_Click(object sender, EventArgs e)
        {

            dugum yeni = new dugum();
            yeni.sayi = Convert.ToInt32(txt_yigin_ekle.Text);
            yeni.baglanti = ilk_yigin_dugum;
            ilk_yigin_dugum = yeni;
            yiginGoster();
        }
        private void yiginGoster()
        {
            txt_yigin_durum.Text = null;
            if (ilk_yigin_dugum == null)
            {
                MessageBox.Show("Yığında Gösterilecek Eleman Bulunamadı");
                return;
            }
            else
            {
                dugum gecici = ilk_yigin_dugum;
                while (gecici !=null)
                {
                    txt_yigin_durum.Text += gecici.sayi + "\r\n";
                    gecici = gecici.baglanti;
                }
            }
        }

       

        private void btn_yigin_cikar_Click(object sender, EventArgs e)
        {

            if (ilk_yigin_dugum == null)
            {
                MessageBox.Show("Yığın Boş");
                return;
            }
            else
            {
                ilk_yigin_dugum = ilk_yigin_dugum.baglanti;
                yiginGoster();
            }
        }
        private void kuyruk_ekle_btn_Click(object sender, EventArgs e)
        {
            dugum yeni = new dugum();
            yeni.sayi = Convert.ToInt32(kyrk_ekle.Text);
            if (on_kuyruk==null)
            {
                on_kuyruk = arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;
            }
            kuyrukGoster();
        }       

        private void kuyrukGoster()
        {
            kyrk_kontrol.Text = null;
            if (arka_kuyruk==null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı!");
                return;
            }
            else
            {
                dugum gecici = on_kuyruk;
                while (gecici != null)
                {
                    kyrk_kontrol.Text += gecici.sayi + "<--";
                    gecici = gecici.baglanti;
                }
            }
        }          

    }
}
