﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BM102Proje
{
    public partial class AsiRandevusu : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb");
        static int adet;
        public AsiRandevusu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void temizle()
        {
            AsiSehir.SelectedIndex = -1;
            AsiSaat.SelectedIndex = -1; //Bu kısımda butona basılınca yazıların temizlenmesi sağlanıyor.
            AsiHastane.Text = "";
        }
        private void GeriDon_Click(object sender, EventArgs e)
        {
            KullanıcıMenü KM = new KullanıcıMenü();
            KM.Show();                                 //Geri dön tuşu ile ana menüye dönmesi sağlanıyor.
            this.Hide();
        }

        private int kontrolsagla()
        {
            string tcno = KullanıcıGirişiMenü.ilet;
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("SELECT count (KimlikNumarası) from AsiRandevulari where KimlikNumarası=@a1", baglantı);
            komut.Parameters.AddWithValue("@a1", tcno);
            adet = System.Convert.ToInt32(komut.ExecuteScalar());  //Burada AsiRandevuları tablomuzdan kullanıcının kimliknumaralarının kaç adet olduğuna baktık. Sonucu adet adlı int değere eşitledik ve döndürdük.
            baglantı.Close();

            return adet;
        }
        private void bilgileriyaz() {
            baglantı.Open();
            string tcno = KullanıcıGirişiMenü.ilet;
            OleDbCommand komut = new OleDbCommand("insert into AsiRandevulari (KimlikNumarası,Sehir,Hastane,Saat,Tarih,AsiTipi) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", tcno);
            komut.Parameters.AddWithValue("@p2", AsiSehir.SelectedItem);
            komut.Parameters.AddWithValue("@p3", AsiHastane.Text);          //Kullanıcı tarafından girilen ya da seçilen verileri database'imize kaydediyoruz.
            komut.Parameters.AddWithValue("@p4", AsiSaat.SelectedItem);
            komut.Parameters.AddWithValue("@p5", AsiTarih.Value.ToString().Substring(0,10));
            komut.Parameters.AddWithValue("@p6", AsiTipi.SelectedItem);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            //Onayla butonuna tıklandığı zaman kutucukların içlerinin boş olup olmamasını kontrol ediyoruz.
            if (AsiHastane.Text!= "" && AsiSehir.SelectedIndex >= 0 && AsiSaat.SelectedIndex >= 0)
            {
                if (kontrolsagla() < 1) { 
                bilgileriyaz();
                MessageBox.Show("Randevunuz oluşturulmuştur."); //tüm kutucuklar doluysa ve o tarihte başka bir randevu yoksa randevu oluşturuluyor ve database'e yazdırmak için bilgileriyaz fonksiyonu çağrılıyor.
                temizle();
                }
                else
                {
                    //eğer seçilen tarih saat doktor için database'de zaten bir başka kayıt varsa uyarıyor.
                    MessageBox.Show("Sistemde daha önceden alınmış bir randevunuz zaten var.");
                }
            }
            else
            {
                //kutulardan en az biri boş ise uyarı veriyor.
                MessageBox.Show("Girdilerde eksik var!");
            }
        }

        private void IptalButon_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
