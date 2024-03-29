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
    public partial class PersonelYönetimi : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\veritabani_access.mdb"); //OleDB bağlantısı
        public int isaretlenmişi_gönder;
        public PersonelYönetimi()
        {
            InitializeComponent();
        }

        private void PersonelYönetimi_Load(object sender, EventArgs e)
        {
            verileri_göster();
        }

        private void verileri_göster() //Data sakladığımız yönetici bilgileri göstermek amacıyla
        {
            int row;
            baglantı.Open();

            // Datadaki verileri yazdırıyoruz
            OleDbDataAdapter da = new OleDbDataAdapter("Select Ad, Soyad, KimlikNumarası, Email, Telefon, Sifre From YoneticiBilgileri ", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            row = dataGridView1.Rows.Count;

            //Datadaki verilerin görünümüyle alakalı
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 135;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 135;
            dataGridView1.Columns[5].Width = 120;

            dataGridView1.Rows[0].Selected = false;

            for(int i=0; i< row -1; i++)
            {
                dataGridView1.Rows[i].Cells[2].ReadOnly = true;    //kimlik numarasını değişime kapatır
            }

            baglantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int isaretlenmis = dataGridView1.SelectedCells[0].RowIndex; //işaretlenmiş indexi işaretlenmiş adlı değişkene atıyoruz
            isaretlenmişi_gönder = isaretlenmis;

        }
        private void yönetici_ekle_Click(object sender, EventArgs e)
        {
            int sayı = 0;

            // Kullanıcının datagridview'e girdiği değerlerin uygun olup olmadığına bakıyoruz
            // İlk olarak boş değerlerin kaydedilmesini engelliyoruz
            if(dataGridView1.Rows[isaretlenmişi_gönder].Cells[0].Value.ToString() == string.Empty || dataGridView1.Rows[isaretlenmişi_gönder].Cells[1].Value.ToString() == string.Empty || dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value.ToString() == string.Empty || dataGridView1.Rows[isaretlenmişi_gönder].Cells[3].Value.ToString() == string.Empty || dataGridView1.Rows[isaretlenmişi_gönder].Cells[4].Value.ToString() == string.Empty || dataGridView1.Rows[isaretlenmişi_gönder].Cells[5].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Boş değer kaydedemezsiniz!");
                temizle();
            }
            else
            {
                // İkinci olarak sistemde kayıtlı olan tc'nin tekrar kaydedilmesini önlüyoruz.
                baglantı.Open();
                OleDbCommand kmt0 = new OleDbCommand("Select KimlikNumarası From YoneticiBilgileri where KimlikNumarası = @a1", baglantı);
                kmt0.Parameters.AddWithValue("@a1", dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value.ToString());
                OleDbDataReader dr = kmt0.ExecuteReader();
                while (dr.Read())
                {
                    sayı++;      
                }
                baglantı.Close();
                if (sayı >= 1)
                {
                    MessageBox.Show("Aynı kimlik numarası için 2 kişi kaydedilemez!");
                    temizle();
                }
                else
                {
                    baglantı.Open();
                    // Kullanıcının datagridview'e girdiği değerleri kaydediyoruz 
                    OleDbCommand kmt1 = new OleDbCommand("insert into YoneticiBilgileri (Ad, Soyad, KimlikNumarası, Email, Telefon, Sifre) values (@a1,@a2,@a3,@a4,@a5,@a6)", baglantı);
                    kmt1.Parameters.AddWithValue("@a1", dataGridView1.Rows[isaretlenmişi_gönder].Cells[0].Value.ToString());
                    kmt1.Parameters.AddWithValue("@a2", dataGridView1.Rows[isaretlenmişi_gönder].Cells[1].Value.ToString());
                    kmt1.Parameters.AddWithValue("@a3", dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value.ToString());
                    kmt1.Parameters.AddWithValue("@a4", dataGridView1.Rows[isaretlenmişi_gönder].Cells[3].Value.ToString());
                    kmt1.Parameters.AddWithValue("@a5", dataGridView1.Rows[isaretlenmişi_gönder].Cells[4].Value.ToString());
                    kmt1.Parameters.AddWithValue("@a6", dataGridView1.Rows[isaretlenmişi_gönder].Cells[5].Value.ToString());
                    kmt1.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla yönetici eklenmiştir.");
                    baglantı.Close();
                }

            }
        }
        private void Yönetici_cıkar_Click(object sender, EventArgs e)
        {
            string kimlik_numarası = dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value.ToString(); //kimlik_numarası adlı değişkene 2 numaralı celldeki(kimliknumarası) değerini atıyoruz

            baglantı.Open();

            OleDbCommand kmt1 = new OleDbCommand("Delete * From YoneticiBilgileri Where KimlikNumarası = @a1", baglantı); //Silme işlemi için komut
            kmt1.Parameters.AddWithValue("@a1", kimlik_numarası);
            kmt1.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Yönetici başarıyla silindi.");
            verileri_göster();  //güncel verileri gösteriyoruz

        }
        private void Güncelle_Click(object sender, EventArgs e)
        {
            //Kısaca yöneticilerin bilgilerinde değişiklik yapılabilmesini sağlıyorum

            string tc;
            tc = dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value.ToString();

            baglantı.Open();

            OleDbCommand kmt = new OleDbCommand("UPDATE YoneticiBilgileri SET Ad = @a1, Soyad = @a2, Email = @a3, Telefon = @a4, Sifre = @a5 Where KimlikNumarası = @a6", baglantı);
            Console.WriteLine(dataGridView1.Rows[isaretlenmişi_gönder].Cells[0].Value.ToString());
            kmt.Parameters.AddWithValue("@a1", dataGridView1.Rows[isaretlenmişi_gönder].Cells[0].Value.ToString());
            kmt.Parameters.AddWithValue("@a2", dataGridView1.Rows[isaretlenmişi_gönder].Cells[1].Value.ToString());
            kmt.Parameters.AddWithValue("@a3", dataGridView1.Rows[isaretlenmişi_gönder].Cells[3].Value.ToString());
            kmt.Parameters.AddWithValue("@a4", dataGridView1.Rows[isaretlenmişi_gönder].Cells[4].Value.ToString());
            kmt.Parameters.AddWithValue("@a5", dataGridView1.Rows[isaretlenmişi_gönder].Cells[5].Value.ToString());
            kmt.Parameters.AddWithValue("@a6", tc);

            kmt.ExecuteNonQuery();
            
            MessageBox.Show("Güncelleme başarıyla yapıldı");
            baglantı.Close();
        }

        private void temizle() // kullanıcı boş girdiğinde veya aynı tc'den girdiğinde celleri temizliyorum
        {
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[0].Value = " ";
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[1].Value = " ";
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[2].Value = " ";
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[3].Value = " ";
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[4].Value = " ";
            dataGridView1.Rows[isaretlenmişi_gönder].Cells[5].Value = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiBilgileri YB = new YoneticiBilgileri();
            YB.Show();
            this.Close();
        }
    }
}
