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
    public partial class Anasayfa : Form  //bu
    {
        string kullaniciadi = "";
        public Anasayfa(string Kullaniciadi)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.Teal700, TextShade.WHITE);
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



        #region Anasayfa Ekranı Load
        private void Anasayfa_Load(object sender, EventArgs e)
        {

            #region Ürünleri Listeler
            SqlCommand komut = new SqlCommand("select * from Urunler", sqlcon);
            sqlcon.Open();
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                boxUrunler.Items.Add(reader["UrunAdi"]);
            }
            reader.Close();
            sqlcon.Close();

            #endregion

            #region Sepeti listeleyen kod

            sepetlistele();

            #endregion

        }
        #endregion

        #region Sepeti listeleyen metot

        void sepetlistele()
        {
            SqlCommand komut1 = new SqlCommand("select * from MusteriTable m inner join Sepett s on m.MusteriID=s.MusteriID " +
                "where KullaniciAdi='" + kullaniciadi + "'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Ürün Adı");
            dataTable.Columns.Add("Ürün Fiyatı");
            dataTable.Columns.Add("Sipariş Adedi");

            SqlDataReader okuyucu = komut1.ExecuteReader();
            while (okuyucu.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Ürün Adı"] = okuyucu["UrunAdi"];
                row["Ürün Fiyatı"] = okuyucu["UrunFiyati"];
                row["Sipariş Adedi"] = okuyucu["UrunAdedi"];

                dataTable.Rows.Add(row);
            }
            dataGridView1.DataSource = dataTable;
            sqlcon.Close();
        }
        #endregion

        #region Sipariş Ver Butonu
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            UyeOdeme uye = new UyeOdeme(2, kullaniciadi);
            this.Hide();
            uye.Show();
        }
        #endregion

        #region Sepete Ekle Butonu
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SepeteEkle", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@urunadi", boxUrunler.Text.Trim());
                    cmd.Parameters.AddWithValue("@urunadedi", txtAdet.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sepete Eklendi");
                    sepetlistele();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Sepete Eklenemedi !");
                    }
                }
                finally
                {
                    sqlcon.Close();
                }
            }


        }
        #endregion

        #region DataGrid'in cellclick'i
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion

        #region Sepet Güncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SepetGuncelle", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@yeniurunadi", boxUrunler.Text.Trim());
                    cmd.Parameters.AddWithValue("@urunadedi", txtAdet.Text.Trim());
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    cmd.Parameters.AddWithValue("@urunadi", textBox1.Text.Trim());

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçtiğiniz Sipariş Güncellendi");
                    sepetlistele();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Seçtiğiniz Sipariş Güncellenemedi !");
                    }
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }
        #endregion

        #region Sepetten Ürün Silen Buton
        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sepetsil", sqlcon))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    cmd.Parameters.AddWithValue("@urunadi", textBox1.Text.Trim());

                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçtiğiniz Sipariş Silindi");
                    sepetlistele();
                }
                catch (Exception ex)
                {
                    var sqlException = ex.InnerException as SqlException;
                    if (sqlException is null)
                    {
                        MessageBox.Show("Seçtiğiniz Sipariş Silinemedi !");
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
