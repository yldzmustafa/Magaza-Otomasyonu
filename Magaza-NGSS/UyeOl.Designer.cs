
namespace Magaza_NGSS
{
    partial class UyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeOl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtAdi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoyadi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefon = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMail = new MaterialSkin.Controls.MaterialTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtKayitTarihi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.boxUyeTipi = new MaterialSkin.Controls.MaterialComboBox();
            this.btnUyeOl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 24);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(743, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(774, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.AnimateReadOnly = false;
            this.txtAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdi.Depth = 0;
            this.txtAdi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdi.Hint = "Adı";
            this.txtAdi.LeadingIcon = null;
            this.txtAdi.Location = new System.Drawing.Point(139, 116);
            this.txtAdi.MaxLength = 50;
            this.txtAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdi.Multiline = false;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(244, 50);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.Text = "";
            this.txtAdi.TrailingIcon = null;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.AnimateReadOnly = false;
            this.txtSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyadi.Depth = 0;
            this.txtSoyadi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoyadi.Hint = "Soyadı";
            this.txtSoyadi.LeadingIcon = null;
            this.txtSoyadi.Location = new System.Drawing.Point(139, 186);
            this.txtSoyadi.MaxLength = 50;
            this.txtSoyadi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoyadi.Multiline = false;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(244, 50);
            this.txtSoyadi.TabIndex = 4;
            this.txtSoyadi.Text = "";
            this.txtSoyadi.TrailingIcon = null;
            // 
            // txtTelefon
            // 
            this.txtTelefon.AnimateReadOnly = false;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.Hint = "Telefon";
            this.txtTelefon.LeadingIcon = null;
            this.txtTelefon.Location = new System.Drawing.Point(139, 256);
            this.txtTelefon.MaxLength = 50;
            this.txtTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefon.Multiline = false;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(244, 50);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.Text = "";
            this.txtTelefon.TrailingIcon = null;
            // 
            // txtMail
            // 
            this.txtMail.AnimateReadOnly = false;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Depth = 0;
            this.txtMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMail.Hint = "E-mail";
            this.txtMail.LeadingIcon = null;
            this.txtMail.Location = new System.Drawing.Point(139, 326);
            this.txtMail.MaxLength = 50;
            this.txtMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 50);
            this.txtMail.TabIndex = 6;
            this.txtMail.Text = "";
            this.txtMail.TrailingIcon = null;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(269, 39);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(263, 38);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "ÜYELİK BİLGİLERİ";
            // 
            // txtKayitTarihi
            // 
            this.txtKayitTarihi.AnimateReadOnly = false;
            this.txtKayitTarihi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKayitTarihi.Depth = 0;
            this.txtKayitTarihi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKayitTarihi.Hint = "Kayıt Tarihi(gg.aa.yyyy)";
            this.txtKayitTarihi.LeadingIcon = null;
            this.txtKayitTarihi.Location = new System.Drawing.Point(412, 256);
            this.txtKayitTarihi.MaxLength = 50;
            this.txtKayitTarihi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKayitTarihi.Multiline = false;
            this.txtKayitTarihi.Name = "txtKayitTarihi";
            this.txtKayitTarihi.Size = new System.Drawing.Size(244, 50);
            this.txtKayitTarihi.TabIndex = 9;
            this.txtKayitTarihi.Text = "";
            this.txtKayitTarihi.TrailingIcon = null;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.Hint = "Kullanıcı Adı";
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(412, 116);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(244, 50);
            this.txtKullaniciAdi.TabIndex = 7;
            this.txtKullaniciAdi.Text = "";
            this.txtKullaniciAdi.TrailingIcon = null;
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(412, 186);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(244, 50);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "";
            this.txtSifre.TrailingIcon = null;
            // 
            // boxUyeTipi
            // 
            this.boxUyeTipi.AutoResize = false;
            this.boxUyeTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.boxUyeTipi.Depth = 0;
            this.boxUyeTipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxUyeTipi.DropDownHeight = 174;
            this.boxUyeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxUyeTipi.DropDownWidth = 121;
            this.boxUyeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.boxUyeTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.boxUyeTipi.FormattingEnabled = true;
            this.boxUyeTipi.Hint = "Üye Tipi";
            this.boxUyeTipi.IntegralHeight = false;
            this.boxUyeTipi.ItemHeight = 43;
            this.boxUyeTipi.Items.AddRange(new object[] {
            "Yok",
            "Normal",
            "Silver",
            "Gold"});
            this.boxUyeTipi.Location = new System.Drawing.Point(412, 327);
            this.boxUyeTipi.MaxDropDownItems = 4;
            this.boxUyeTipi.MouseState = MaterialSkin.MouseState.OUT;
            this.boxUyeTipi.Name = "boxUyeTipi";
            this.boxUyeTipi.Size = new System.Drawing.Size(244, 49);
            this.boxUyeTipi.StartIndex = 0;
            this.boxUyeTipi.TabIndex = 10;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.ActiveBorderThickness = 1;
            this.btnUyeOl.ActiveCornerRadius = 20;
            this.btnUyeOl.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnUyeOl.ActiveForecolor = System.Drawing.Color.White;
            this.btnUyeOl.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(50)))));
            this.btnUyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.BackgroundImage")));
            this.btnUyeOl.ButtonText = "Üye Ol";
            this.btnUyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeOl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeOl.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUyeOl.IdleBorderThickness = 1;
            this.btnUyeOl.IdleCornerRadius = 20;
            this.btnUyeOl.IdleFillColor = System.Drawing.Color.White;
            this.btnUyeOl.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUyeOl.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUyeOl.Location = new System.Drawing.Point(308, 406);
            this.btnUyeOl.Margin = new System.Windows.Forms.Padding(5);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(181, 41);
            this.btnUyeOl.TabIndex = 12;
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.boxUyeTipi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtKayitTarihi);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜyeOl";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
        private MaterialSkin.Controls.MaterialTextBox txtTelefon;
        private MaterialSkin.Controls.MaterialTextBox txtSoyadi;
        private MaterialSkin.Controls.MaterialTextBox txtAdi;
        private MaterialSkin.Controls.MaterialComboBox boxUyeTipi;
        private MaterialSkin.Controls.MaterialTextBox txtSifre;
        private MaterialSkin.Controls.MaterialTextBox txtKullaniciAdi;
        private MaterialSkin.Controls.MaterialTextBox txtKayitTarihi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUyeOl;
    }
}