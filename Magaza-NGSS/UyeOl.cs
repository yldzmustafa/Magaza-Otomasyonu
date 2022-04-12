using Magaza_NGSS.Classlar;
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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

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

        //SQL BAĞLANTI ADRESİ
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-1VO3R9G;Initial Catalog=NGSS;Integrated Security=True");


        #region Üye Ol Butonu
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdi.Text != "" && txtSoyadi.Text != "" && txtKayitTarihi.Text != "" && txtKullaniciAdi.Text != "" &&
                    txtSifre.Text != "" && txtTelefon.Text != "" && txtMail.Text != "")
                {
                    using (Kullanici nesne = new Kullanici())
                    {
                        nesne.KullaniciAdi = txtKullaniciAdi.Text;
                        nesne.Sifre = txtSifre.Text;
                        nesne.Telefon = txtTelefon.Text;
                        nesne.Email = txtMail.Text;



                        using (SqlCommand cmd = new SqlCommand("musteriuyeol", sqlcon))
                        {
                            try
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text.Trim());
                                cmd.Parameters.AddWithValue("@SoyAdi", txtSoyadi.Text.Trim());
                                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text.Trim());
                                cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                                cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text.Trim());
                                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                                cmd.Parameters.AddWithValue("@KayitTarihi", txtKayitTarihi.Text.Trim());
                                cmd.Parameters.AddWithValue("@KartTipi", boxUyeTipi.Text.Trim());

                                SqlParameter outPutParameter = new SqlParameter();
                                outPutParameter.ParameterName = "@id";
                                outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                                cmd.Parameters.Add(outPutParameter);
                                sqlcon.Open();
                                cmd.ExecuteNonQuery();
                                if (outPutParameter.Value.ToString() == "1")
                                {
                                    MessageBox.Show("Aynı kullanıcı adı daha önce alınmış");
                                }

                                if (boxUyeTipi.Text == "Gold" || boxUyeTipi.Text == "Silver" || boxUyeTipi.Text == "Normal")
                                {
                                    MessageBox.Show("Seçtiğiniz üye tipi ücretlidir");
                                    int a = 1;
                                    UyeOdeme uyeOdeme = new UyeOdeme(a, txtKullaniciAdi.Text.Trim());
                                    this.Hide();
                                    uyeOdeme.Show();
                                }
                                else
                                {
                                    int a = 1;
                                    UyeOdeme uyeOdeme = new UyeOdeme(a, txtKullaniciAdi.Text.Trim());
                                    this.Hide();
                                    uyeOdeme.Show();
                                    MessageBox.Show("Üye oldunuz lütfen faturanızı oluşturun");
                                    //Login login = new Login();
                                    //this.Hide();
                                    //login.Show();

                                }
                            }


                            catch (Exception ex)
                            {
                                var sqlException = ex.InnerException as SqlException;
                                if (sqlException is null)
                                {
                                    MessageBox.Show("Bu Kullanıcı Mevcut");
                                }
                            }
                            finally
                            {
                                sqlcon.Close();
                            }

                        }

                    }
                }
                else
                    MessageBox.Show("Lütfen alanları kontrol ediniz !");


            }
            catch (ArgumentException exc)
            {

                MessageBox.Show(exc.Message);
            }

        }
        #endregion
    }
}
