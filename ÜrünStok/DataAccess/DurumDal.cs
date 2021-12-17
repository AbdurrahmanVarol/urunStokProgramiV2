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
    public class DurumDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Durum> GetAll(string str = null)
        {
            List<Durum> durums = new List<Durum>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Durum";
            else
            {
                komut.CommandText = "select*from Durum where @str";
                komut.Parameters.AddWithValue("@str", str);
            }
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Durum durum = new Durum
                {
                    DurumId = Convert.ToInt32(dr["DurumId"]),
                    DurumAd = dr["DurumAd"].ToString()
                };
                durums.Add(durum);
            }
            dr.Close();
            _baglanti.Close();

            return durums;
        }
        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from Durum";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["DurumId"]) == sayac)
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
        public Durum Get(string str = null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Durum";
            else
            {
                komut.CommandText = "select*from Durum where " + str;
            }
            dr = komut.ExecuteReader();
            dr.Read();
            Durum durum = new Durum
            {
                DurumId = Convert.ToInt32(dr["DurumId"]),
                DurumAd = dr["DurumAd"].ToString()
            };
            dr.Close();
            _baglanti.Close();
            return  durum;
        }
        public void Add(Durum durum)
        {
            durum.DurumId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Dolap (DurumId,DurumAd) values(@DurumId,@DurumAd)";
            komut.Parameters.AddWithValue("@DurumId", durum.DurumId.ToString());
            komut.Parameters.AddWithValue("@DurumAd", durum.DurumAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Durum where DurumId=@DurumAd";
            komut.Parameters.AddWithValue("@DurumId", id.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Durum durum)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE KullaniciId SET DurumAd=@DurumAd where DurumId=@DurumId";
            komut.Parameters.AddWithValue("@DurumId", durum.DurumId.ToString());
            komut.Parameters.AddWithValue("@DurumAd", durum.DurumAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
