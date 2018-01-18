namespace Yilbasi_yazilimi
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGidenMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGMail = new System.Windows.Forms.TextBox();
            this.TxtGMailSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(89, 221);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(387, 23);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.Text = "SİSTEME KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GEÇERLİ MAİL ADRESİ KAYDEDİNİZ:";
            // 
            // TxtGidenMail
            // 
            this.TxtGidenMail.Location = new System.Drawing.Point(287, 185);
            this.TxtGidenMail.Name = "TxtGidenMail";
            this.TxtGidenMail.Size = new System.Drawing.Size(189, 20);
            this.TxtGidenMail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BU YAZILIM YENİ YILININ İLK DAKİKASI MUTLU YILLAR MAİLİ ATMAKLA GÖREVLİDİR ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İŞLEM YAPACAK GERÇERLİ MAİL ADRESİ:";
            // 
            // TxtGMail
            // 
            this.TxtGMail.Location = new System.Drawing.Point(314, 69);
            this.TxtGMail.Name = "TxtGMail";
            this.TxtGMail.Size = new System.Drawing.Size(162, 20);
            this.TxtGMail.TabIndex = 1;
            // 
            // TxtGMailSifre
            // 
            this.TxtGMailSifre.Location = new System.Drawing.Point(287, 109);
            this.TxtGMailSifre.Name = "TxtGMailSifre";
            this.TxtGMailSifre.Size = new System.Drawing.Size(189, 20);
            this.TxtGMailSifre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MAİL ADRESİNİN ŞİFRESİNİ GİRİN:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(286, 147);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(189, 20);
            this.TxtAd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "GÖNDEREN KİŞİNİN ADINI GİRİN:";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 271);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtGMailSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtGidenMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKaydet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMail";
            this.Text = "HAPPY NEW YEAR MAİL SENDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGidenMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGMail;
        private System.Windows.Forms.TextBox TxtGMailSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
    }
}

