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
    public class BolmeDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");


        public List<Bolme> GetAll(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            List<Bolme> bolmes = new List<Bolme>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Bolme";
            else
                komut.CommandText = "select*from Bolme where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Bolme bolme = new Bolme
                {
                    BolmeId = Convert.ToInt32(dr["BolmeId"]),
                    KutuId = Convert.ToInt32(dr["KutuId"]),
                    BolmeAd = dr["BolmeAd"].ToString()
                };
                bolmes.Add(bolme);
            }
            dr.Close();
            _baglanti.Close();
            return bolmes;
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
            komut.CommandText = "select * from Bolme";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["BolmeId"]) == sayac)
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
        public Bolme Get(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Bolme";
            else
                komut.CommandText = "select*from Bolme where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            Bolme bolme = new Bolme
            {
                BolmeId = Convert.ToInt32(dr["BolmeId"]),
                KutuId = Convert.ToInt32(dr["KutuId"]),
                BolmeAd = dr["BolmeAd"].ToString()
            };
            dr.Close();
            _baglanti.Close();
            return bolme;
        }
        public void Add(Bolme bolme)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            bolme.BolmeId= id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Bolme(BolmeId,KutuId,BolmeAd) values(@BolmeId,@KutuId,@BolmeAd)";
            komut.Parameters.AddWithValue("@BolmeId",bolme.BolmeId);
            komut.Parameters.AddWithValue("@KutuId", bolme.KutuId);
            komut.Parameters.AddWithValue("@BolmeAd", bolme.BolmeAd);
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
            komut.CommandText = "delete from Bolme where BolmeId=@BolmeId";
            komut.Parameters.AddWithValue("@BolmeId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Bolme bolme)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Bolme SET BolmeAd=@BolmeAd";
            komut.Parameters.AddWithValue("@BolmeAd", bolme.BolmeAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
