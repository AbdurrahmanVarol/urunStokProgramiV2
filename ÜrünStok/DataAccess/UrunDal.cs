using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ÜrünStok.Entities;

namespace ÜrünStok.DataAccess
{
    public class UrunDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<Urun> GetAll(string str = null)
        {
            List<Urun> uruns = new List<Urun>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Urun";
            else
                komut.CommandText = "select*from Urun where " + str;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Urun urun = new Urun
                {
                    UrunId = Convert.ToInt32(dr["UrunId"]),
                    KategoriId = Convert.ToInt32(dr["KategoriId"]),
                    KonumId = Convert.ToInt32(dr["KonumId"]),
                    UrunAd = dr["UrunAd"].ToString(),
                    RafId = Convert.ToInt32(dr["RafId"]),
                    DurumId = Convert.ToInt32(dr["DurumId"]),
                    UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                    StokMiktari = Convert.ToInt32(dr["StokMiktari"])
                };
                uruns.Add(urun);
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
            komut.CommandText = "select * from urun";
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
        public Urun Get(string str = null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(str))
                komut.CommandText = "select*from Urun";
            else
                komut.CommandText = "select*from Urun where " + str;
            dr = komut.ExecuteReader();
            dr.Read();
            Urun urun = new Urun
            {
                UrunId = Convert.ToInt32(dr["UrunId"]),
                KategoriId = Convert.ToInt32(dr["KategoriId"]),
                KonumId = Convert.ToInt32(dr["KonumId"]),
                UrunAd = dr["UrunAd"].ToString(),
                RafId = Convert.ToInt32(dr["RafId"]),
                DurumId = Convert.ToInt32(dr["DurumId"]),
                UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                StokMiktari = Convert.ToInt32(dr["StokMiktari"])
            };
            _baglanti.Close();
            dr.Close();
            return urun;
        }
        public void Add(Urun urun)
        {
            urun.UrunId = id_bul();
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "insert into Urun(UrunId,KategoriId,KonumId,UrunAd,DurumId,RafId,UrunAdet,StokMiktari) values(@UrunId,@KategoriId,@KonumId,@UrunAd,@DurumId,@RafId,@UrunAdet,@StokMiktari)";
            komut.Parameters.AddWithValue("@UrunId", urun.UrunId.ToString());
            komut.Parameters.AddWithValue("@KategoriId", urun.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KonumId", urun.KonumId.ToString());
            komut.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            komut.Parameters.AddWithValue("@RafId", urun.RafId.ToString());
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
            komut.CommandText = "delete from Urun where UrunId=@UrunId";
            komut.Parameters.AddWithValue("@UrunId", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
        public void Update(Urun urun)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            komut.CommandText = "UPDATE Urun SET KategoriId=@KategoriId,KonumId=@KonumId,UrunAd=@UrunAd,RafId=@RafId,DurumId=@DurumId,UrunAdet=@UrunAdet,StokMiktari=@StokMiktari where UrunId=@UrunId";
            komut.Parameters.AddWithValue("@KategoriId", urun.KategoriId.ToString());
            komut.Parameters.AddWithValue("@KonumId", urun.KonumId.ToString());            
            komut.Parameters.AddWithValue("@UrunAd", urun.UrunAd);
            komut.Parameters.AddWithValue("@RafId", urun.RafId.ToString());
            komut.Parameters.AddWithValue("@DurumId", urun.DurumId.ToString());
            komut.Parameters.AddWithValue("@UrunAdet", urun.UrunAdet.ToString());
            komut.Parameters.AddWithValue("@StokMiktari", urun.StokMiktari.ToString());
            komut.Parameters.AddWithValue("@UrunId", urun.UrunId);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
