using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ÜrünStok.Entities;

namespace ÜrünStok.Class_1_
{
   public class UrunSahaDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<UrunSaha> GetAll(string str = null)
        {
            List<UrunSaha> urunsahas = new List<UrunSaha>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from UrunSahas";
            else
                komut.CommandText = "select*from UrunSahas where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                UrunSaha urunsaha = new UrunSaha
                {
                    UrunId = Convert.ToInt32(dr["Id"]),
                    KategoriId = Convert.ToInt32(dr["KategoriId"]),
                    KonumId = Convert.ToInt32(dr["KonumId"]),
                    UrunAd = dr["UrunAdı"].ToString(),
                    DurumId = Convert.ToInt32(dr["DurumId"]),
                    UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                    StokMiktari = Convert.ToInt32(dr["StokMiktari"])
                };
                urunsahas.Add(urunsaha);
            }
            _baglanti.Close();
            dr.Close();
            return urunsahas;
        }
        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from urunsaha";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["id"]) == sayac)
                {
                    sayac++;
                }
                else
                {
                    break;
                }
            }
            _baglanti.Close();
            dr.Close();
            return sayac;
        }
        public UrunSaha Get(int id)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "select*from UrunSahas where Id=" + id.ToString();
            dr = komut.ExecuteReader();
            dr.Read();
            UrunSaha urunsaha = new UrunSaha
            {
                UrunId = Convert.ToInt32(dr["Id"]),
                KategoriId = Convert.ToInt32(dr["KategoriId"]),
                UrunAd = dr["UrunAdı"].ToString(),
                KonumId = Convert.ToInt32(dr["KonumId"]),
                DurumId = Convert.ToInt32(dr["DurumId"]),
                UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                StokMiktari = Convert.ToInt32(dr["StokMiktari"])
            };
            _baglanti.Close();
            dr.Close();
            return urunsaha;
        }
        public void Add(UrunSaha urunsaha)
        {
            urunsaha.UrunId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into UrunSahas(UrunId,KategoriId,UrunAdı,KonumId,DurumId,UrunAdet,StokMiktari) values(@UrunId,@KategoriId,@UrunAdı,@KonumId,@DurumId,@UrunAdet,@StokMiktari)";
            komut.Parameters.AddWithValue("@UrunId", urunsaha.UrunId.ToString());
            komut.Parameters.AddWithValue("@KategoriId", urunsaha.KategoriId.ToString());
            komut.Parameters.AddWithValue("@UrunAdı", urunsaha.UrunAd);
            komut.Parameters.AddWithValue("@KonumId", urunsaha.KonumId.ToString());
            komut.Parameters.AddWithValue("@DurumId", urunsaha.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", urunsaha.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", urunsaha.StokMiktari.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from Uruns where Id=@id";
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(UrunSaha urunsaha)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE UrunSahas SET KategoriId =@KategoriId,UrunAdı=@UrunAdı,RafId=@RafId,DurumId=@DurumId,UrunAdet=@UrunAdet,StokAdet=@StokAdet ,UrunId=@UrunID where Id=@id";
            komut.Parameters.AddWithValue("@KategoriId", urunsaha.KategoriId.ToString());
            komut.Parameters.AddWithValue("@UrunAdı", urunsaha.UrunAd);
            komut.Parameters.AddWithValue("@KonumId", urunsaha.KonumId.ToString());
            komut.Parameters.AddWithValue("@DurumId", urunsaha.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", urunsaha.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", urunsaha.StokMiktari.ToString());
            komut.Parameters.AddWithValue("@UrunId", urunsaha.UrunId.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
