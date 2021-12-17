using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ÜrünStok.Entities;

namespace ÜrünStok.Class
{
    class UrunHangarDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");

        public List<UrunHangar> GetAll(string str = null)
        {
            List<UrunHangar> uruns = new List<UrunHangar>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from UrunHangars";
            else
                komut.CommandText = "select*from UrunHangars where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                UrunHangar hangar = new UrunHangar
                {
                    UrunId = Convert.ToInt32(dr["Id"]),
                    KategoriId = Convert.ToInt32(dr["KategoriId"]),
                    UrunAd = dr["UrunAdı"].ToString(),
                    KonumId = Convert.ToInt32(dr["KonumId"]),
                    DurumId = Convert.ToInt32(dr["DurumId"]),
                    UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                    StokMiktari = Convert.ToInt32(dr["StokMiktari"])
                };
                uruns.Add(hangar);
            }
            _baglanti.Close();
            dr.Close();
            return uruns;
        }

        public int id_bul()
        {
            SqlCommand komut = new SqlCommand();
            SqlDataReader dr;
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            int sayac = 1;
            _baglanti.Open();
            komut.CommandText = "select * from urunHangar";
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
        public UrunHangar Get(int id)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "select*from Uruns where Id=" + id.ToString();
            dr = komut.ExecuteReader();
            dr.Read();
            UrunHangar hangar = new UrunHangar
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
            return hangar;
        }
        public void Add(UrunHangar urun)
        {
            urun.UrunId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Uruns(UrunId,KategoriId,UrunAdı,RafId,DurumId,UrunAdet,StokAdet) values(@UrunId,@KategoriId,@UrunAdı,@RafId,@DurumId,@UrunAdet,@StokAdet)";
            komut.Parameters.AddWithValue("@UrunId", urun.UrunId.ToString());
            komut.Parameters.AddWithValue("@KategoriId", urun.KategoriId.ToString());
            komut.Parameters.AddWithValue("@UrunAdı", urun.UrunAd);
            komut.Parameters.AddWithValue("@KonumId", urun.KonumId.ToString());
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
            komut.CommandText = "delete from UrunHangars where Id=@id";
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(UrunHangar hangar)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Uruns SET KategoriId =@KategoriId,UrunAdı=@UrunAdı,RafId=@RafId,DurumId=@DurumId,UrunAdet=@UrunAdet,StokAdet=@StokAdet where Id=@id";
            komut.Parameters.AddWithValue("@KategoriId", hangar.KategoriId.ToString());
            komut.Parameters.AddWithValue("@UrunAdı", hangar.UrunAd);
            komut.Parameters.AddWithValue("@RafId", hangar.KonumId.ToString());
            komut.Parameters.AddWithValue("@DurumId", hangar.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", hangar.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", hangar.StokMiktari.ToString());
            komut.Parameters.AddWithValue("@id", hangar.UrunId);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
