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
    public partial class UyeOdeme : Form
    {
        int b = 0;
        string kullaniciadi = "";
        public UyeOdeme(int a,string Kullaniciadi)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Teal700, TextShade.WHITE);
            this.b = a;
            this.kullaniciadi = Kullaniciadi;
        }

        //SQL BAĞLANTI ADRESİ
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-1VO3R9G;Initial Catalog=NGSS;Integrated Security=True");

        #region Uygulama Çıkış Butonu
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

        #region Ödeme Yap Butonu
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (b == 1)
            {
                #region Kredi Kartı Ekleme
                using (SqlCommand cmd = new SqlCommand("KKekle", sqlcon))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@kartnumarasi", txtKartNumarasi.Text.Trim());
                        cmd.Parameters.AddWithValue("@ay", boxAy.Text.Trim());
                        cmd.Parameters.AddWithValue("@yil", boxYil.Text.Trim());
                        cmd.Parameters.AddWithValue("@cvv", txtCvv.Text.Trim());
                        cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        var sqlException = ex.InnerException as SqlException;
                        if (sqlException is null)
                        {
                            MessageBox.Show("Bu Kart Mevcut");
                        }
                    }
                    finally
                    {
                        sqlcon.Close();
                    }
                }
                #endregion

                #region Üyelik Fatura Ekleme
                using (SqlCommand cmd = new SqlCommand("FaturaKayit", sqlcon))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Faturanız Oluşturuldu.");
                    }
                    catch (Exception ex)
                    {
                        var sqlException = ex.InnerException as SqlException;
                        if (sqlException is null)
                        {
                            MessageBox.Show("Fatura Oluşturulamadı !");
                        }
                    }
                    finally
                    {
                        sqlcon.Close();
                    }
                }

                #endregion

                FaturaUyelik fatura = new FaturaUyelik(kullaniciadi);
                this.Hide();
                fatura.Show();
            }

            else
            {
                using (SqlCommand cmd = new SqlCommand("FaturaUrunn", sqlcon))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                        sqlcon.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Faturanız Oluşturuldu.");
                    }
                    catch (Exception ex)
                    {
                        var sqlException = ex.InnerException as SqlException;
                        if (sqlException is null)
                        {
                            MessageBox.Show("Fatura Oluşturulamadı !");
                        }
                    }
                    finally
                    {
                        sqlcon.Close();
                    }
                }



                Fatura fatura = new Fatura(kullaniciadi);
                this.Hide();
                fatura.Show();
            }

        }
        #endregion

        #region Ödeme Ekranı Load
        private void UyeOdeme_Load(object sender, EventArgs e)
        {
            using (SqlCommand komut = new SqlCommand("select * from MusteriTable m inner join" +
               " KKBilgileri k on m.MusteriID=k.KKID where m.KullaniciAdi = " + "'" + kullaniciadi + "'", sqlcon))
            {
                sqlcon.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    boxAy.Items.Add(reader["Ay"]);
                    boxYil.Items.Add(reader["Yıl"]);
                    txtKartNumarasi.Text = ((string)reader["KartNumarasi"]);
                    txtCvv.Text = ((string)reader["Cvv"]);
                }
                reader.Close();
                sqlcon.Close();
            };

        }
        #endregion


    }
}
