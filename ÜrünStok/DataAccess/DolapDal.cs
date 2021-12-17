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
    public class DolapDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Dolap> GetAll(string str = null)
        {
            List<Dolap> dolaps = new List<Dolap>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Dolap";
            else
            {
                komut.CommandText = "select*from Dolap where @str";
                komut.Parameters.AddWithValue("@str", str);
            }
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Dolap dolap = new Dolap
                {
                    DolapId = Convert.ToInt32(dr["DolapId"]),
                    DolapAd = dr["DolapAd"].ToString()
                };
                dolaps.Add(dolap);
            }
            dr.Close();
            _baglanti.Close();

            return dolaps;
        }
        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from Dolap";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["DolapId"]) == sayac)
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
        public Dolap Get(string str = null)
        {
                SqlDataReader dr;
                SqlCommand komut = new SqlCommand();
                komut.Connection = _baglanti;
                komut.CommandType = CommandType.Text;
                _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Dolap";
            else
            {
                komut.CommandText = "select*from Dolap where "+ str;
            }
            dr = komut.ExecuteReader();
                dr.Read();
                Dolap dolap = new Dolap
                {
                    DolapId = Convert.ToInt32(dr["DolapId"]),
                    DolapAd = dr["DolapAd"].ToString()
                };
                dr.Close();
                _baglanti.Close();
                return dolap;
        }
        public void Add(Dolap dolap)
        {
            dolap.DolapId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Dolap (DolapId,DolapAd) values(@DolapId,@DolapAd)";
            komut.Parameters.AddWithValue("@DolapId", dolap.DolapId.ToString());
            komut.Parameters.AddWithValue("@DolapAd", dolap.DolapAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Dolap where DolapId=@DolapId";
            komut.Parameters.AddWithValue("@DolapId", id.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Dolap dolap)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE KullaniciId SET DolapAd=@DolapAd where DolapId=@DolapId";
            komut.Parameters.AddWithValue("@DolapId", dolap.DolapId.ToString());
            komut.Parameters.AddWithValue("@DolapAd", dolap.DolapAd);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
