using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ÜrünStok.Entities;

namespace ÜrünStok.DataAccess
{
    public class LogDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");

        public List<Log> GetAll(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            List<Log> logs = new List<Log>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Log";
            else
                komut.CommandText = "select*from Log where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Log log = new Log
                {
                    UrunId = Convert.ToInt32(dr["UrunId"]),
                    LogId = Convert.ToInt32(dr["LogId"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    KullaniciAd = dr["KullaniciAd"].ToString(),
                    YetkiId = Convert.ToInt32(dr["YetkiId"]),
                    Islem = dr["Islem"].ToString(),
                    Tarih = dr["Tarih"].ToString()
                };
                logs.Add(log);
            }
            dr.Close();
            _baglanti.Close();
            return logs;
        }     
        public Log Get(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Log";
            else
                komut.CommandText = "select*from Log where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            Log log = new Log
            {
                LogId = Convert.ToInt32(dr["LogId"]),
                UrunId = Convert.ToInt32(dr["UrunId"]),
                UrunAd = dr["UrunAd"].ToString(),
                KullaniciAd = dr["KullaniciId"].ToString(),
                YetkiId = Convert.ToInt32(dr["YetkiId"]),
                Islem = dr["Islem"].ToString(),
                Tarih = dr["Tarih"].ToString()
            };
            dr.Close();
            _baglanti.Close();
            return log;
        }
        public void Add(Log log)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Log(UrunId,UrunAd,KullaniciAd,YetkiId,Islem,Tarih) values(@UrunId,@UrunAd,@KullaniciAd,@YetkiId,@Islem,@Tarih)";
            komut.Parameters.AddWithValue("@UrunId", log.UrunId.ToString());           
            komut.Parameters.AddWithValue("@UrunAd", log.UrunAd);
            komut.Parameters.AddWithValue("@KullaniciAd", log.KullaniciAd);
            komut.Parameters.AddWithValue("@YetkiId", log.YetkiId.ToString());
            komut.Parameters.AddWithValue("@Islem", log.Islem.ToString());
            komut.Parameters.AddWithValue("@Tarih", log.Tarih.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Log where LogId=@LogId";
            komut.Parameters.AddWithValue("@LogId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Log log)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Logs SET UrunId=@UrunId,UrunAd=@UrunAd,Islem=@Islem,Tarih=@Tarih where LogId=@LogId";
            komut.Parameters.AddWithValue("@LogId",log.LogId);
            komut.Parameters.AddWithValue("@UrunId", log.UrunId);
            komut.Parameters.AddWithValue("@UrunAd", log.UrunAd);
            komut.Parameters.AddWithValue("@Islem", log.Islem);
            komut.Parameters.AddWithValue("@Tarih", log.Tarih);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
