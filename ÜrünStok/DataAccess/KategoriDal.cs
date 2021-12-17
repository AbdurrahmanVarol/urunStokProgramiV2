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
    public class KategoriDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Kategori> GetAll(string str = null)
        {
            List<Kategori> kategoris = new List<Kategori>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kategori";
            else
            {
                komut.CommandText = "select*from Kategori where" + str;
            }
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kategori kategori = new Kategori
                {
                    KategoriId = Convert.ToInt32(dr["KategoriId"]),
                    KategoriAd = dr["KategoriAd"].ToString()
                };
                kategoris.Add(kategori);
            }
            dr.Close();
            _baglanti.Close();
            return kategoris;
        }
        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from Kategori";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["KategoriId"]) == sayac)
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
        public Kategori Get(string str= null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kategori";
            else
            {
                komut.CommandText = "select*from Kategori where " + str;
            }
            dr = komut.ExecuteReader();
            dr.Read();
            Kategori kategori = new Kategori
            {
                KategoriId = Convert.ToInt32(dr["KategoriId"]),
                KategoriAd = dr["KategoriAd"].ToString()
            };
            dr.Close();
            _baglanti.Close();
            return kategori;
        }
        public void Add(Kategori kategori)
        {
            kategori.KategoriId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Kategori(KategoriId,KategoriAd) values(@KategoriId,@KategoriAd)";
            komut.Parameters.AddWithValue("@KategoriId", kategori.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KategoriAd", kategori.KategoriAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Kategori where KategoriId=@KategoriId";
            komut.Parameters.AddWithValue("@KategoriId", id.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Kategori kategori)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE KullaniciId SET KategoriAd=@KategoriAd where KategoriId=@KategoriId";
            komut.Parameters.AddWithValue("@KategoriId", kategori.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KategoriAd", kategori.KategoriAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
