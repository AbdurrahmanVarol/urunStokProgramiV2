using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ÜrünStok.Entities;

namespace ÜrünStok.Class
{
    class RafDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Raf> GetAll(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            List<Raf> rafs = new List<Raf>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Raf";
            else
                komut.CommandText = "select*from Raf where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Raf raf = new Raf
                {
                    RafId = Convert.ToInt32(dr["RafId"]),
                    DolapId = Convert.ToInt32(dr["DolapId"]),
                    RafAd = dr["RafAd"].ToString(),
                };
                rafs.Add(raf);
            }
            dr.Close();
            _baglanti.Close();            
            return rafs;
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
            komut.CommandText = "select * from Raf";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["RafId"]) == sayac)
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
        public Raf Get(string str = null)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Raf";
            else
                komut.CommandText = "select*from Raf where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            Raf raf = new Raf
            {
                RafId = Convert.ToInt32(dr["RafId"]),
                DolapId = Convert.ToInt32(dr["DolapId"]),
                RafAd = dr["RafAd"].ToString(),
            };
            dr.Close();
            _baglanti.Close();
            
            return raf;
        }
        public void Add(Raf raf)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            raf.RafId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Raf(RafId,DolapId,RafAd) values(@RafId,@DolapId,@RafAd)";
            komut.Parameters.AddWithValue("@RafId", raf.RafId.ToString());
            komut.Parameters.AddWithValue("@DolapId", raf.DolapId.ToString());
            komut.Parameters.AddWithValue("@RafAd", raf.RafAd);
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
            komut.CommandText = "delete from Raf where RafId=@RafId";
            komut.Parameters.AddWithValue("@RafId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Raf raf)
        {
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Raf SET where RafId=@RafId";
            komut.Parameters.AddWithValue("@RafId", raf.RafId.ToString());
            komut.Parameters.AddWithValue("@RafAd", raf.RafAd);
            komut.Parameters.AddWithValue("@DolapId", raf.DolapId.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}

  
