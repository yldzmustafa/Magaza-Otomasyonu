
namespace Magaza_NGSS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtGirisAdi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGirisSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnGiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnuyeol = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuyeol)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(442, 24);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(384, 0);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(415, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtGirisAdi
            // 
            this.txtGirisAdi.AnimateReadOnly = false;
            this.txtGirisAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGirisAdi.Depth = 0;
            this.txtGirisAdi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGirisAdi.Hint = "Kullanıcı Adı";
            this.txtGirisAdi.LeadingIcon = null;
            this.txtGirisAdi.Location = new System.Drawing.Point(101, 165);
            this.txtGirisAdi.MaxLength = 50;
            this.txtGirisAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGirisAdi.Multiline = false;
            this.txtGirisAdi.Name = "txtGirisAdi";
            this.txtGirisAdi.Size = new System.Drawing.Size(244, 50);
            this.txtGirisAdi.TabIndex = 1;
            this.txtGirisAdi.Text = "";
            this.txtGirisAdi.TrailingIcon = null;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.AnimateReadOnly = false;
            this.txtGirisSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGirisSifre.Depth = 0;
            this.txtGirisSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGirisSifre.Hint = "Şifre";
            this.txtGirisSifre.LeadingIcon = null;
            this.txtGirisSifre.Location = new System.Drawing.Point(101, 250);
            this.txtGirisSifre.MaxLength = 50;
            this.txtGirisSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGirisSifre.Multiline = false;
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Password = true;
            this.txtGirisSifre.Size = new System.Drawing.Size(244, 50);
            this.txtGirisSifre.TabIndex = 2;
            this.txtGirisSifre.Text = "";
            this.txtGirisSifre.TrailingIcon = null;
            // 
            // btnGiris
            // 
            this.btnGiris.ActiveBorderThickness = 1;
            this.btnGiris.ActiveCornerRadius = 20;
            this.btnGiris.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnGiris.ActiveForecolor = System.Drawing.Color.White;
            this.btnGiris.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(50)))));
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.ButtonText = "Giriş Yap";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.IdleBorderThickness = 1;
            this.btnGiris.IdleCornerRadius = 20;
            this.btnGiris.IdleFillColor = System.Drawing.Color.White;
            this.btnGiris.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGiris.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.Location = new System.Drawing.Point(126, 362);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(181, 41);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnuyeol
            // 
            this.btnuyeol.BackColor = System.Drawing.Color.Transparent;
            this.btnuyeol.Image = ((System.Drawing.Image)(resources.GetObject("btnuyeol.Image")));
            this.btnuyeol.ImageActive = null;
            this.btnuyeol.Location = new System.Drawing.Point(322, 302);
            this.btnuyeol.Name = "btnuyeol";
            this.btnuyeol.Size = new System.Drawing.Size(24, 24);
            this.btnuyeol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnuyeol.TabIndex = 4;
            this.btnuyeol.TabStop = false;
            this.btnuyeol.Zoom = 10;
            this.btnuyeol.Click += new System.EventHandler(this.btnuyeol_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(274, 307);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 15);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Üye Ol";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(149, 55);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(147, 47);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "LOGİN";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(442, 494);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnuyeol);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.txtGirisAdi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuyeol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private MaterialSkin.Controls.MaterialTextBox txtGirisAdi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGiris;
        private MaterialSkin.Controls.MaterialTextBox txtGirisSifre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnuyeol;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

