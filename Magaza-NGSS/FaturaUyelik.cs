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
    public partial class FaturaUyelik : Form
    {
        string kullaniciadi = "";
        public FaturaUyelik(string KullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciadi = KullaniciAdi;
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

        #region Giriş Ekranına yönlendiren Buton
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        #endregion

        #region Uyelik Fatura Ekranı Load
        private void FaturaUyelik_Load(object sender, EventArgs e)
        {
            faturalistele();
        }
        #endregion

        #region Faturayı listeleyen metot
        void faturalistele()
        {
            using (SqlCommand cmd = new SqlCommand("UyeFaturaListele", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    sqlcon.Open();

                    DataTable dataTable = new DataTable();

                    dataTable.Columns.Add("Fatura No");
                    dataTable.Columns.Add("Kullanıcı Adı");
                    dataTable.Columns.Add("Kayıt Tarihi");
                    dataTable.Columns.Add("Üyelik Kart Tipi");
                    dataTable.Columns.Add("Kart Ücreti");

                    SqlDataReader okuyucu = cmd.ExecuteReader();
                    while (okuyucu.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["Fatura No"] = okuyucu["FaturaNo"];
                        row["Kullanıcı Adı"] = okuyucu["KullaniciAdi"];
                        row["Kayıt Tarihi"] = okuyucu["KayıtTarihi"];
                        row["Üyelik Kart Tipi"] = okuyucu["KartTipi"];
                        row["Kart Ücreti"] = okuyucu["Fiyat"];

                        dataTable.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dataTable;
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Fatura Listelenemedi !");
                    }
                }
                finally
                {
                    sqlcon.Close();
                }
            }

        }
        #endregion


    }
}
