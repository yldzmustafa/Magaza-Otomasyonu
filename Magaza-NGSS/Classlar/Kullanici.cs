using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaza_NGSS.Classlar
{
    public class Kullanici : IDisposable
    {


        public string kullaniciadi;
        public string sifre;
        public string telefon;
        public string adi;
        public string soyadi;
        public string email;



        public string KullaniciAdi 
        {
            get
            {
                return kullaniciadi;
            }
            set
            {
                bool oldumu = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        oldumu = true;
                        break;
                    }
                }
                if (oldumu)
                {
                    throw new ArgumentException("Kullanıcı adı sadece harflerden oluşmalıdır !");
                    
                }
                else
                {
                    this.kullaniciadi = value;
                }
            }
        }
        public string Sifre 
        {
            get
            {
                return sifre;
                
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Şifreniz 8 karakterden az olamaz !");
                }
                int a;
                if (!int.TryParse(value, out a))
                {
                    throw new ArgumentException("Şifreniz sadece sayılardan oluşmalıdır!");
                }
                else
                {
                    this.sifre = a.ToString();
                }
            }
        }

        public string Adi 
        {
            get
            {
                return adi;
            }
            set
            {
                bool oldumu = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        oldumu = true;
                        break;
                    }
                }
                if (oldumu)
                {
                    throw new ArgumentException("Adınız sadece harflerden oluşmalıdır !");

                }
                else
                {
                    this.adi = value;
                }
            }
        }

        public string Soyadi 
        {
            get
            {
                return soyadi;
            }
            set
            {
                bool oldumu = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        oldumu = true;
                        break;
                    }
                }
                if (oldumu)
                {
                    throw new ArgumentException("Soyadınız sadece harflerden oluşmalıdır !");

                }
                else
                {
                    this.soyadi = value;
                }
            }
        }

        public string Telefon 
        {
            get
            {
                return telefon;
            }

            set
            {
                if (value.Length < 11)
                {
                    throw new ArgumentException("Telefon numaranız 11 karakterden az olamaz !");
                }
                else
                {
                    this.telefon = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                bool oldumu = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i].ToString() == "@")
                    {
                        oldumu = true;
                        break;
                    }
                }
                if (!oldumu)
                {
                    throw new ArgumentException("Mailiniz '(örnek:@xxx.com)' formatında olmalıdır !");

                }
                else
                {
                    this.email = value;
                }
            }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }

       
    }
}
