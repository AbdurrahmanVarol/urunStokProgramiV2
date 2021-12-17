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
    class UrunKutuDal
    {

        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");

        public List<UrunKutu> GetAll(string str = null)
        {
            List<UrunKutu> urunKutus = new List<UrunKutu>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from UrunKutu";
            else
                komut.CommandText = "select*from UrunKutu where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                UrunKutu kutu = new UrunKutu
                {
                    UrunId = Convert.ToInt32(dr["UrunId"]),
                    KategoriId = Convert.ToInt32(dr["KategoriId"]),
                    KonumId = Convert.ToInt32(dr["KonumId"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    BolmeId = Convert.ToInt32(dr["BolmeId"]),
                    DurumId = Convert.ToInt32(dr["DurumId"]),
                    UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                    StokMiktari = Convert.ToInt32(dr["StokMiktari"])
                };
                urunKutus.Add(kutu);
            }
            dr.Close();
            _baglanti.Close();
            
            return urunKutus;
        }

        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from UrunKutu";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["UrunId"]) == sayac)
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
        public UrunKutu Get(string str = null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from UrunKutu";
            else
                komut.CommandText = "select*from UrunKutu where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            UrunKutu kutu = new UrunKutu
            {
                UrunId = Convert.ToInt32(dr["UrunId"]),
                KategoriId = Convert.ToInt32(dr["KategoriId"]),
                KonumId = Convert.ToInt32(dr["KonumId"]),
                UrunAd = dr["UrunAd"].ToString(),
                BolmeId = Convert.ToInt32(dr["BolmeId"]),
                DurumId = Convert.ToInt32(dr["DurumId"]),
                UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                StokMiktari = Convert.ToInt32(dr["StokMiktari"])

            };
            _baglanti.Close();
            dr.Close();
            return kutu;
        }
        public void Add(UrunKutu urun)
        {
            urun.UrunId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into UrunKutu(UrunId,KategoriId,KonumId,UrunAd,DurumId,BolmeId,UrunAdet,StokMiktari) values(@UrunId,@KategoriId,@KonumId,@UrunAd,@DurumId,@BolmeId,@UrunAdet,@StokMiktari)";
            komut.Parameters.AddWithValue("@UrunId", urun.UrunId.ToString());
            komut.Parameters.AddWithValue("@KategoriId", urun.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KonumId", urun.KonumId.ToString());
            komut.Parameters.AddWithValue("@BolmeId", urun.BolmeId.ToString());
            komut.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            komut.Parameters.AddWithValue("@DurumId", urun.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", urun.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", urun.StokMiktari.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Delete(int id)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "delete from UrunKutu where UrunId=@UrunId";
            komut.Parameters.AddWithValue("@UrunId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(UrunKutu kutu)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE UrunKutu SET KategoriId=@KategoriId,KonumId=@KonumId,UrunAd=@UrunAd,BolmeId=@BolmeId,DurumId=@DurumId,UrunAdet=@UrunAdet,StokMiktari=@StokMiktari where UrunId=@UrunId";
            komut.Parameters.AddWithValue("@KategoriId", kutu.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KonumId", kutu.KonumId.ToString());
            komut.Parameters.AddWithValue("@UrunAd", kutu.UrunAd);
            komut.Parameters.AddWithValue("@BolmeId", kutu.BolmeId.ToString());
            komut.Parameters.AddWithValue("@DurumId", kutu.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", kutu.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", kutu.StokMiktari.ToString());
            komut.Parameters.AddWithValue("@UrunId", kutu.UrunId.ToString());
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}

