namespace SiparisOtomasyon
{
    partial class Form1
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
            this.yoneticiAd = new System.Windows.Forms.TextBox();
            this.yoneticiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YoneticiRadio = new System.Windows.Forms.RadioButton();
            this.YoneticiGrpBox = new System.Windows.Forms.GroupBox();
            this.MusteriGrpBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.musteriAd = new System.Windows.Forms.TextBox();
            this.musteriAdres = new System.Windows.Forms.TextBox();
            this.musteriSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MusteriRadio = new System.Windows.Forms.RadioButton();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.YoneticiGrpBox.SuspendLayout();
            this.MusteriGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yoneticiAd
            // 
            this.yoneticiAd.Location = new System.Drawing.Point(129, 18);
            this.yoneticiAd.Name = "yoneticiAd";
            this.yoneticiAd.Size = new System.Drawing.Size(100, 24);
            this.yoneticiAd.TabIndex = 0;
            // 
            // yoneticiSifre
            // 
            this.yoneticiSifre.Location = new System.Drawing.Point(129, 74);
            this.yoneticiSifre.Name = "yoneticiSifre";
            this.yoneticiSifre.Size = new System.Drawing.Size(100, 24);
            this.yoneticiSifre.TabIndex = 1;
            this.yoneticiSifre.TextChanged += new System.EventHandler(this.yoneticiSifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // YoneticiRadio
            // 
            this.YoneticiRadio.AutoSize = true;
            this.YoneticiRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.YoneticiRadio.Location = new System.Drawing.Point(199, 27);
            this.YoneticiRadio.Name = "YoneticiRadio";
            this.YoneticiRadio.Size = new System.Drawing.Size(119, 22);
            this.YoneticiRadio.TabIndex = 4;
            this.YoneticiRadio.TabStop = true;
            this.YoneticiRadio.Text = "Yönetici Girişi";
            this.YoneticiRadio.UseVisualStyleBackColor = true;
            this.YoneticiRadio.CheckedChanged += new System.EventHandler(this.YoneticiRadio_CheckedChanged);
            // 
            // YoneticiGrpBox
            // 
            this.YoneticiGrpBox.Controls.Add(this.label1);
            this.YoneticiGrpBox.Controls.Add(this.yoneticiAd);
            this.YoneticiGrpBox.Controls.Add(this.yoneticiSifre);
            this.YoneticiGrpBox.Controls.Add(this.label2);
            this.YoneticiGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.YoneticiGrpBox.Location = new System.Drawing.Point(33, 73);
            this.YoneticiGrpBox.Name = "YoneticiGrpBox";
            this.YoneticiGrpBox.Size = new System.Drawing.Size(255, 115);
            this.YoneticiGrpBox.TabIndex = 5;
            this.YoneticiGrpBox.TabStop = false;
            this.YoneticiGrpBox.Text = "Yönetici Girişi";
            // 
            // MusteriGrpBox
            // 
            this.MusteriGrpBox.Controls.Add(this.label3);
            this.MusteriGrpBox.Controls.Add(this.musteriAd);
            this.MusteriGrpBox.Controls.Add(this.musteriAdres);
            this.MusteriGrpBox.Controls.Add(this.musteriSifre);
            this.MusteriGrpBox.Controls.Add(this.label5);
            this.MusteriGrpBox.Controls.Add(this.label4);
            this.MusteriGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MusteriGrpBox.Location = new System.Drawing.Point(33, 73);
            this.MusteriGrpBox.Name = "MusteriGrpBox";
            this.MusteriGrpBox.Size = new System.Drawing.Size(281, 164);
            this.MusteriGrpBox.TabIndex = 6;
            this.MusteriGrpBox.TabStop = false;
            this.MusteriGrpBox.Text = "Müşteri Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // musteriAd
            // 
            this.musteriAd.Location = new System.Drawing.Point(129, 21);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(100, 24);
            this.musteriAd.TabIndex = 0;
            // 
            // musteriAdres
            // 
            this.musteriAdres.Location = new System.Drawing.Point(129, 127);
            this.musteriAdres.Name = "musteriAdres";
            this.musteriAdres.Size = new System.Drawing.Size(100, 24);
            this.musteriAdres.TabIndex = 2;
            // 
            // musteriSifre
            // 
            this.musteriSifre.Location = new System.Drawing.Point(129, 74);
            this.musteriSifre.Name = "musteriSifre";
            this.musteriSifre.Size = new System.Drawing.Size(100, 24);
            this.musteriSifre.TabIndex = 1;
            this.musteriSifre.TextChanged += new System.EventHandler(this.musteriSifre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre";
            // 
            // MusteriRadio
            // 
            this.MusteriRadio.AutoSize = true;
            this.MusteriRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MusteriRadio.Location = new System.Drawing.Point(33, 27);
            this.MusteriRadio.Name = "MusteriRadio";
            this.MusteriRadio.Size = new System.Drawing.Size(116, 22);
            this.MusteriRadio.TabIndex = 4;
            this.MusteriRadio.TabStop = true;
            this.MusteriRadio.Text = "Müşteri Girişi";
            this.MusteriRadio.UseVisualStyleBackColor = true;
            this.MusteriRadio.CheckedChanged += new System.EventHandler(this.MusteriRadio_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Pink;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGiris.Location = new System.Drawing.Point(330, 91);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(101, 41);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Pink;
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKayitOl.Location = new System.Drawing.Point(330, 167);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(101, 40);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 271);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.MusteriGrpBox);
            this.Controls.Add(this.YoneticiGrpBox);
            this.Controls.Add(this.MusteriRadio);
            this.Controls.Add(this.YoneticiRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.YoneticiGrpBox.ResumeLayout(false);
            this.YoneticiGrpBox.PerformLayout();
            this.MusteriGrpBox.ResumeLayout(false);
            this.MusteriGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yoneticiAd;
        private System.Windows.Forms.TextBox yoneticiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton YoneticiRadio;
        private System.Windows.Forms.GroupBox YoneticiGrpBox;
        private System.Windows.Forms.RadioButton MusteriRadio;
        private System.Windows.Forms.GroupBox MusteriGrpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox musteriAd;
        private System.Windows.Forms.TextBox musteriSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox musteriAdres;
        private System.Windows.Forms.Label label5;
    }
}

