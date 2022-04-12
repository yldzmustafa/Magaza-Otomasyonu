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
    public partial class Fatura : Form
    {

        //SQL BAĞLANTI ADRESİ
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-1VO3R9G;Initial Catalog=NGSS;Integrated Security=True");


        string kullaniciadi = "";
        public Fatura(string KullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciadi = KullaniciAdi;
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

        #region Fatura Sayfası Load
        private void Fatura_Load(object sender, EventArgs e)
        {
            siparisfaturalistele();
        }
        #endregion

        #region Sipariş Listeleyen Buton
        void siparisfaturalistele()
        {
            using (SqlCommand cmd = new SqlCommand("siparislistele", sqlcon))
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
                    dataTable.Columns.Add("Üyelik Süresi(Yıl)");
                    dataTable.Columns.Add("Üyelik Kart Tipi");
                    dataTable.Columns.Add("Ürün Adı");
                    dataTable.Columns.Add("Ürün Fiyatı");
                    dataTable.Columns.Add("Adet");
                    dataTable.Columns.Add("Üye Kartı İndirimi(X%100)");
                    dataTable.Columns.Add("Fatura İndirimi");
                    dataTable.Columns.Add("Toplam Tutar");

                    SqlDataReader okuyucu = cmd.ExecuteReader();
                    while (okuyucu.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["Fatura No"] = okuyucu["UrunFaturaNo"];
                        row["Kullanıcı Adı"] = okuyucu["KullaniciAdi"];
                        row["Kayıt Tarihi"] = okuyucu["KayıtTarihi"];
                        row["Üyelik Süresi(Yıl)"] = okuyucu["KayıtlıSure"];
                        row["Üyelik Kart Tipi"] = okuyucu["KartTipi"];
                        row["Ürün Adı"] = okuyucu["UrunAdi"];
                        row["Ürün Fiyatı"] = okuyucu["UrunFiyati"];
                        row["Adet"] = okuyucu["UrunAdedi"];
                        row["Üye Kartı İndirimi(X%100)"] = okuyucu["KartIndirimi"];
                        row["Fatura İndirimi"] = okuyucu["FaturaIndirim"];
                        row["Toplam Tutar"] = okuyucu["ToplamTutar"];
                        dataTable.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dataTable;          
                    dataGridView1.Columns[10].Visible = false;
                    sqlcon.Close();
                    lblsonuc.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
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

        #region Uygulama Çıkışı ve içeriği temizleyen buton
        private void btncikisyap_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Sepetisil", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Sepet silinemedi !");
                    }
                }
                finally
                {
                    sqlcon.Close();
                }
            }
            using (SqlCommand cmd = new SqlCommand("Faturasil", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Sepet silinemedi !");
                    }
                }
                finally
                {
                    sqlcon.Close();
                }
            }
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        #endregion
    }
}
