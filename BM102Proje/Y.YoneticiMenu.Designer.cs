﻿
namespace BM102Proje
{
    partial class YoneticiMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.saat = new System.Windows.Forms.Label();
            this.tarihsaat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdoktorekle = new System.Windows.Forms.Label();
            this.txtrandevular = new System.Windows.Forms.Label();
            this.txthastaliste = new System.Windows.Forms.Label();
            this.bilgiguncelle = new System.Windows.Forms.PictureBox();
            this.doktorekle = new System.Windows.Forms.PictureBox();
            this.aktifrandevular = new System.Windows.Forms.PictureBox();
            this.hastalistesi = new System.Windows.Forms.PictureBox();
            this.geridon = new System.Windows.Forms.PictureBox();
            this.hosgeldin = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiguncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktifrandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geridon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(638, 365);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.saat);
            this.bunifuGradientPanel2.Controls.Add(this.tarihsaat);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.txtdoktorekle);
            this.bunifuGradientPanel2.Controls.Add(this.txtrandevular);
            this.bunifuGradientPanel2.Controls.Add(this.txthastaliste);
            this.bunifuGradientPanel2.Controls.Add(this.bilgiguncelle);
            this.bunifuGradientPanel2.Controls.Add(this.doktorekle);
            this.bunifuGradientPanel2.Controls.Add(this.aktifrandevular);
            this.bunifuGradientPanel2.Controls.Add(this.hastalistesi);
            this.bunifuGradientPanel2.Controls.Add(this.geridon);
            this.bunifuGradientPanel2.Controls.Add(this.hosgeldin);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(526, 362);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Cambria", 12F);
            this.saat.Location = new System.Drawing.Point(430, 55);
            this.saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(71, 19);
            this.saat.TabIndex = 32;
            this.saat.Text = "22:19:21";
            this.saat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tarihsaat
            // 
            this.tarihsaat.AutoSize = true;
            this.tarihsaat.BackColor = System.Drawing.Color.Transparent;
            this.tarihsaat.Font = new System.Drawing.Font("Cambria", 15F);
            this.tarihsaat.Location = new System.Drawing.Point(413, 31);
            this.tarihsaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tarihsaat.Name = "tarihsaat";
            this.tarihsaat.Size = new System.Drawing.Size(106, 23);
            this.tarihsaat.TabIndex = 31;
            this.tarihsaat.Text = "15.05.2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(397, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ekstra İşlemler";
            // 
            // txtdoktorekle
            // 
            this.txtdoktorekle.AutoSize = true;
            this.txtdoktorekle.BackColor = System.Drawing.Color.Transparent;
            this.txtdoktorekle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdoktorekle.Location = new System.Drawing.Point(281, 202);
            this.txtdoktorekle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtdoktorekle.Name = "txtdoktorekle";
            this.txtdoktorekle.Size = new System.Drawing.Size(91, 19);
            this.txtdoktorekle.TabIndex = 29;
            this.txtdoktorekle.Text = "Doktor Ekle";
            // 
            // txtrandevular
            // 
            this.txtrandevular.AutoSize = true;
            this.txtrandevular.BackColor = System.Drawing.Color.Transparent;
            this.txtrandevular.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrandevular.Location = new System.Drawing.Point(146, 202);
            this.txtrandevular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtrandevular.Name = "txtrandevular";
            this.txtrandevular.Size = new System.Drawing.Size(89, 19);
            this.txtrandevular.TabIndex = 28;
            this.txtrandevular.Text = "Randevular";
            // 
            // txthastaliste
            // 
            this.txthastaliste.AutoSize = true;
            this.txthastaliste.BackColor = System.Drawing.Color.Transparent;
            this.txthastaliste.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastaliste.Location = new System.Drawing.Point(19, 202);
            this.txthastaliste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txthastaliste.Name = "txthastaliste";
            this.txthastaliste.Size = new System.Drawing.Size(96, 19);
            this.txthastaliste.TabIndex = 27;
            this.txthastaliste.Text = "Hasta Listesi";
            // 
            // bilgiguncelle
            // 
            this.bilgiguncelle.BackColor = System.Drawing.Color.Transparent;
            this.bilgiguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bilgiguncelle.BackgroundImage")));
            this.bilgiguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bilgiguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgiguncelle.Location = new System.Drawing.Point(400, 90);
            this.bilgiguncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bilgiguncelle.Name = "bilgiguncelle";
            this.bilgiguncelle.Size = new System.Drawing.Size(107, 109);
            this.bilgiguncelle.TabIndex = 26;
            this.bilgiguncelle.TabStop = false;
            this.bilgiguncelle.Click += new System.EventHandler(this.bilgiguncelle_Click);
            // 
            // doktorekle
            // 
            this.doktorekle.BackColor = System.Drawing.Color.Transparent;
            this.doktorekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorekle.BackgroundImage")));
            this.doktorekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doktorekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorekle.Location = new System.Drawing.Point(269, 90);
            this.doktorekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doktorekle.Name = "doktorekle";
            this.doktorekle.Size = new System.Drawing.Size(107, 109);
            this.doktorekle.TabIndex = 25;
            this.doktorekle.TabStop = false;
            this.doktorekle.Click += new System.EventHandler(this.doktorekle_Click);
            // 
            // aktifrandevular
            // 
            this.aktifrandevular.BackColor = System.Drawing.Color.Transparent;
            this.aktifrandevular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aktifrandevular.BackgroundImage")));
            this.aktifrandevular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aktifrandevular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aktifrandevular.Location = new System.Drawing.Point(137, 90);
            this.aktifrandevular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aktifrandevular.Name = "aktifrandevular";
            this.aktifrandevular.Size = new System.Drawing.Size(107, 109);
            this.aktifrandevular.TabIndex = 24;
            this.aktifrandevular.TabStop = false;
            this.aktifrandevular.Click += new System.EventHandler(this.aktifrandevular_Click);
            // 
            // hastalistesi
            // 
            this.hastalistesi.BackColor = System.Drawing.Color.Transparent;
            this.hastalistesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastalistesi.BackgroundImage")));
            this.hastalistesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastalistesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastalistesi.Location = new System.Drawing.Point(15, 90);
            this.hastalistesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hastalistesi.Name = "hastalistesi";
            this.hastalistesi.Size = new System.Drawing.Size(107, 109);
            this.hastalistesi.TabIndex = 23;
            this.hastalistesi.TabStop = false;
            this.hastalistesi.Click += new System.EventHandler(this.hastalistesi_Click);
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.Transparent;
            this.geridon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geridon.BackgroundImage")));
            this.geridon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geridon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geridon.Location = new System.Drawing.Point(15, 27);
            this.geridon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(28, 28);
            this.geridon.TabIndex = 22;
            this.geridon.TabStop = false;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // hosgeldin
            // 
            this.hosgeldin.AutoSize = true;
            this.hosgeldin.BackColor = System.Drawing.Color.Transparent;
            this.hosgeldin.Font = new System.Drawing.Font("Cambria", 15F);
            this.hosgeldin.Location = new System.Drawing.Point(47, 31);
            this.hosgeldin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hosgeldin.Name = "hosgeldin";
            this.hosgeldin.Size = new System.Drawing.Size(149, 23);
            this.hosgeldin.TabIndex = 0;
            this.hosgeldin.Text = "Sayın, xxxx xxxx";
            // 
            // YoneticiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 280);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YoneticiMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiMenu_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiguncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktifrandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geridon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label hosgeldin;
        private System.Windows.Forms.PictureBox geridon;
        private System.Windows.Forms.Label tarihsaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtdoktorekle;
        private System.Windows.Forms.Label txtrandevular;
        private System.Windows.Forms.Label txthastaliste;
        private System.Windows.Forms.PictureBox bilgiguncelle;
        private System.Windows.Forms.PictureBox doktorekle;
        private System.Windows.Forms.PictureBox aktifrandevular;
        private System.Windows.Forms.PictureBox hastalistesi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saat;
    }
}