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
    public class KutuDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");


        public List<Kutu> GetAll(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            List<Kutu> kutus = new List<Kutu>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kutu";
            else
                komut.CommandText = "select*from Kutu where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kutu kutu = new Kutu
                {
                    KutuId = Convert.ToInt32(dr["KutuId"]),
                    RafId = Convert.ToInt32(dr["RafId"]),
                    KutuAd = dr["KutuAd"].ToString()
                };
                kutus.Add(kutu);
            }
            dr.Close();
            _baglanti.Close();
            return kutus;
        }
        public int id_bul()
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from Kutu";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["KutuId"]) == sayac)
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
        public Kutu Get(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Kutu";
            else
                komut.CommandText = "select*from Kutu where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            Kutu kutu = new Kutu
            {
                KutuId = Convert.ToInt32(dr["KutuId"]),
                RafId = Convert.ToInt32(dr["RafId"]),
                KutuAd = dr["KutuAd"].ToString(),
            };
            dr.Close();
            _baglanti.Close();            
            return kutu;
        }
        public void Add(Kutu kutu)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            kutu.KutuId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Kutu(KutuId,RafId,KutuAd) values(@KutuId,@RafId,@KutuAd)";
            komut.Parameters.AddWithValue("@KutuId", kutu.KutuId.ToString());
            komut.Parameters.AddWithValue("@RafId", kutu.RafId.ToString());
            komut.Parameters.AddWithValue("@KutuAd", kutu.KutuAd);
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
            komut.CommandText = "delete from Kutu where KutuId=@KutuId";
            komut.Parameters.AddWithValue("@KutuId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Kutu kutu)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Uruns SET RafId=@RafId,KutuAd=@KutuAd";
            komut.Parameters.AddWithValue("@RafId", kutu.RafId);
            komut.Parameters.AddWithValue("@KutuAd", kutu.KutuAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}

