﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data.OleDb;

namespace BM102Proje
{


    public partial class KullanıcıGirişiMenü : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb"); //OleDb bağlantısı
        public KullanıcıGirişiMenü()
        {
            InitializeComponent();
            sifregizle.Hide();
        }
        private void TxtKimlikNumarası_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        static string RoboKodd;
        public static string ilet;
        private void temizle()      //TxtBoxları temizliyoruz
        {
            TxtKimlikNumarası.Text = "";
            password.Text = "";
            TxtRoboKodGiriş.Text = "";
            RoboKodGörünüm.Text = "";
            TxtRoboKodGiriş.Text = "";
        }
        private void RoboKodSaklama()
        {
            RoboKodGörünüm.Visible = false;         //RoboKod'un gereçlerini panel açıldığı an gözükmesin diye ayarlıyorum
            RoboKodBilgi.Visible = false;
            TxtRoboKodGiriş.Visible = false;
            Giriş2.Visible = false;
        }

        public string RoboKod()
        {
            char[] RoboKod = new char[6];
            Random RandomKomud = new Random();
            StringBuilder stringbuild = new StringBuilder();    //Alttaki döngüde atanan her char değerini string haline dönüştürmek için kullanıyorum
            for(int i=0; i<6; i++)
            {
                if (i % 2 == 0)
                {
                    RoboKod[i] = Convert.ToChar(RandomKomud.Next(48, 57));  //i Çiftken sayı ataması yapıyorum(ASCII'de 48-57 arası 0'dan 9 kadar olan sayılar) 
                    stringbuild.Append(RoboKod[i]);         //Kodları stringbuild ile string olarak ekliyorum
                }
                else
                {
                    RoboKod[i] = Convert.ToChar(RandomKomud.Next(97, 122)); //i tekken harf ataması yapıyorum (ASCII'de 97-122 arası alfabenin küçük hafleri)
                    stringbuild.Append(RoboKod[i]);         //Kodları stringbuild ile string olarak ekliyorum
                }
            }
            return stringbuild.ToString();
        }

        public void okuma()
        {
            baglantı.Open();
            OleDbCommand KGK = new OleDbCommand("Select * From HastaBilgileri where HastaKimlikNumarası=@a1 and HastaSifre=@a2", baglantı);
            KGK.Parameters.AddWithValue("@a1", TxtKimlikNumarası.Text); //@a1'e girilen kimlik numarasını atıyorum
            KGK.Parameters.AddWithValue("@a2", password.Text);   //@a2'ye girilen şifreyi atıyorum
            OleDbDataReader dr = KGK.ExecuteReader();

            //baglanti.Open();
            //SqlCommand KullanıcıGirişKomudu = new SqlCommand("Select * From HastaBilgileri where HastaKimlikNumarası=@a1 and HastaSifre=@a2", baglanti);
            //KullanıcıGirişKomudu.Parameters.AddWithValue("@a1", TxtKimlikNumarası.Text); //@a1'e girilen kimlik numarasını atıyorum
            //KullanıcıGirişKomudu.Parameters.AddWithValue("@a2", TxtSifreGirisi.Text);   //@a2'ye girilen şifreyi atıyorum
            //SqlDataReader dr = KullanıcıGirişKomudu.ExecuteReader();

            if (dr.Read())      // @a1 ile @a2 Sql'deki dosyada varsa çalışır
            {
                Gİriş1.Visible = false;
                Giriş2.Visible = true;
                RoboKodd = RoboKod();       //RoboKodd adlı değişkene robotkodunu atıyorum
                RoboKodGörünüm.Text = RoboKodd;   //RoboKodu'un gereçlerini görünür yapıyorum
                RoboKodGörünüm.Visible = true;
                RoboKodBilgi.Visible = true;
                TxtRoboKodGiriş.Visible = true;
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                temizle();              //TextBoxları temizledik
            }
            //baglanti.Close();
            baglantı.Close();
        }
        private void KullanıcıGirişiMenü_Load(object sender, EventArgs e)
        {
            RoboKodSaklama();
        }

        private void Gİriş1_Click(object sender, EventArgs e)
        {
            okuma();
        }
        private void Giriş2_Click(object sender, EventArgs e)
        {
            
            if (RoboKodd == TxtRoboKodGiriş.Text || TxtRoboKodGiriş.Text == "111")
            {
                MessageBox.Show("Girişiniz yapılıyor...");
                Thread.Sleep(3);
                ilet = TxtKimlikNumarası.Text;
                KullanıcıMenü KM = new KullanıcıMenü();
                KM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uyuşmayan kod!");
                RoboKodSaklama();
                Gİriş1.Visible = true;
                Giriş2.Visible = false;
                temizle();
            }
        }
        private void KayıtOl_Click(object sender, EventArgs e)
        {
            KayıtOlPaneli KOP = new KayıtOlPaneli();
            KOP.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SifremiUnuttumPaneli SUP = new SifremiUnuttumPaneli();
            SUP.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GirişPaneli GP = new GirişPaneli();
            GP.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GirişPaneli GP = new GirişPaneli();
            GP.Show();
            this.Hide();
        }

        private void sifregizle_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '●';
            sifregizle.Hide();
            sifregoster.Show();
        }

        private void sifregoster_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '\0';
            sifregoster.Hide();
            sifregizle.Show();
        }
    }
}
