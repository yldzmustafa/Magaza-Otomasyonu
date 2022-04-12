using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaza_NGSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Teal700, TextShade.WHITE);
        }

        #region Çıkış Butonu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region Minimize Butonu
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        //SQL BAĞLANTI ADRESİ
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-1VO3R9G;Initial Catalog=NGSS;Integrated Security=True");

        #region Uygulama Giriş Butonu
        private void btnGiris_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("musterigiris", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kullaniciadi", txtGirisAdi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtGirisSifre.Text);

                    SqlParameter sqlParameter = new SqlParameter();
                    sqlParameter.ParameterName = "@id";
                    sqlParameter.SqlDbType = System.Data.SqlDbType.Int;
                    sqlParameter.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(sqlParameter);
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();

                    if (sqlParameter.Value.ToString() == "0")
                        MessageBox.Show("BU KULLANICI MEVCUT DEĞİL LÜTFEN ÜYE OLUNUZ");
                    else
                    {
                        MessageBox.Show("Giriş Başarılı");
                        Anasayfa anasayfa = new Anasayfa(txtGirisAdi.Text.Trim());
                        this.Hide();
                        anasayfa.Show();
                    }
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                var sqlException = ex.InnerException as SqlException;
                if (sqlException is null)
                {
                    MessageBox.Show("Bu Kullanıcı Mevcut Değil");
                }

            }

        }
        #endregion

        #region Üye Ol Butonu
        private void btnuyeol_Click(object sender, EventArgs e)
        {
            UyeOl üye = new UyeOl();
            this.Hide();
            üye.Show();
        }
        #endregion

    }
}
