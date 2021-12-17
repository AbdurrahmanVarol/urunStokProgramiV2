using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.Entities;

namespace ÜrünStok.DataAccess
{
    public class KullaniciDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Kullanici> GetAll(string str = null)
        {
            List<Kullanici> kullanicis = new List<Kullanici>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kullanici";
            else
            {
                komut.CommandText = "select*from Kullanici where @str";
                komut.Parameters.AddWithValue("@str",str);
            }                
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kullanici kullanici = new Kullanici
                {
                    KullaniciId=Convert.ToInt32(dr["KullaniciId"]),
                    KullaniciAdi=dr["KullaniciAd"].ToString(),
                    KullaniciSifre=dr["KullaniciSifre"].ToString(),
                    KullaniciYetki = Convert.ToInt32(dr["YetkiId"])
                };
                kullanicis.Add(kullanici);
            }
            dr.Close();
            _baglanti.Close();            
            return kullanicis;
        }
        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from Kullanici";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["KullaniciId"]) == sayac)
                {
                    sayac++;
                }
                else
                {
                    break;
                }
            }
            dr.Close();
            _baglanti.Close();            
            return sayac;
        }
        public Kullanici Get(string str= null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kullanici";
            else
            {
                komut.CommandText = "select*from Kullanici where @str";
                komut.Parameters.AddWithValue("@str", str);
            }
            dr = komut.ExecuteReader();
            dr.Read();
            Kullanici urun = new Kullanici
            {
                KullaniciId = Convert.ToInt32(dr["KullaniciId"]),
                KullaniciAdi = dr["KullaniciAd"].ToString(),
                KullaniciSifre = dr["KullaniciSifre"].ToString(),
                KullaniciYetki = Convert.ToInt32(dr["YetkiId"])
            };
            dr.Close();
            _baglanti.Close();           
            return urun;
        }
        public void Add(Kullanici kullanici)
        {
            kullanici.KullaniciId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Kullanici(KullaniciId,KullaniciAd,KullaniciSifre,YetkiId) values(@KullaniciId,@KullaniciAd,@KullaniciSifre,@YetkiId)";
            komut.Parameters.AddWithValue("@KullaniciId", kullanici.KullaniciId.ToString());
            komut.Parameters.AddWithValue("@KullaniciAd", kullanici.KullaniciAdi);
            komut.Parameters.AddWithValue("@KullaniciSifre", kullanici.KullaniciSifre);
            komut.Parameters.AddWithValue("@YetkiId", kullanici.KullaniciYetki.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {   
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Kullanici where KullaniciId=@KullaniciId";
            komut.Parameters.AddWithValue("@KullaniciId", id.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Kullanici kullanici)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Kullanici SET KullaniciAd=@KullaniciAd,KullaniciSifre=@KullaniciSifre,YetkiId=@YetkiId where KullaniciId=@KullaniciId";
            komut.Parameters.AddWithValue("@KullaniciId", kullanici.KullaniciId.ToString());
            komut.Parameters.AddWithValue("@KullaniciAd", kullanici.KullaniciAdi);
            komut.Parameters.AddWithValue("@KullaniciSifre", kullanici.KullaniciSifre);
            komut.Parameters.AddWithValue("@YetkiId", kullanici.KullaniciYetki.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
