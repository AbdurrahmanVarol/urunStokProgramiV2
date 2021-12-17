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
    public class UrunListeDal
    {
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        public List<UrunListe> GetAll(string tablo, string sorgu = null)
        {
            List< UrunListe > urunListes  = new List<UrunListe>();
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(sorgu) && tablo == "Urun")
                komut.CommandText = "select \r\n" +
                "Urun.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "Urun.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Urun.UrunAdet as UrunAdet,\r\n" +
                "Urun.StokMiktari as Stok\r\n" +
                "from Urun\r\n" +
                "inner join Kategori on Kategori.KategoriId= Urun.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= Urun.KonumId\r\n" +
                "inner join Raf on Raf.RafId = Urun.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId\r\n" +
                "inner join Durum on Durum.DurumId = Urun.DurumId";
            else if (!string.IsNullOrEmpty(sorgu) && tablo == "Urun")
                komut.CommandText = "select \r\n" +
                "Urun.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "Urun.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Urun.UrunAdet as UrunAdet,\r\n" +
                "Urun.StokMiktari as Stok\r\n" +
                "from Urun\r\n" +
                "inner join Kategori on Kategori.KategoriId= Urun.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= Urun.KonumId\r\n" +
                "inner join Raf on Raf.RafId = Urun.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId\r\n" +
                "inner join Durum on Durum.DurumId = Urun.DurumId\r\n" +
                "where " + sorgu;
            else if (string.IsNullOrEmpty(sorgu) && tablo == "UrunKutu")
                komut.CommandText = "select\r\n" +
                "UrunKutu.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "UrunKutu.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Kutu.KutuAd as Kutu,\r\n" +
                "Bolme.BolmeAd as Bolme,\r\n" +
                "UrunKutu.UrunAdet as UrunAdet,\r\n" +
                "UrunKutu.StokMiktari as Stok\r\n" +
                "from UrunKutu\r\n" +
                "inner join Kategori on Kategori.KategoriId= UrunKutu.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= UrunKutu.KonumId\r\n" +
                "inner join Durum on Durum.DurumId = UrunKutu.DurumId\r\n" +
                "inner join Bolme on Bolme.BolmeId = UrunKutu.BolmeId\r\n" +
                "inner join Kutu on Kutu.KutuId = Bolme.KutuId\r\n" +
                "inner join Raf on Raf.RafId = Kutu.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId";
            else if (!string.IsNullOrEmpty(sorgu) && tablo == "UrunKutu")
                komut.CommandText = "select\r\n" +
                "	UrunKutu.UrunId as UrunId,\r\n" +
                "	Kategori.KategoriAd as Kategori,\r\n" +
                "    Konum.KonumAd as Konum,\r\n" +
                "    UrunKutu.UrunAd as Urun,\r\n" +
                "    Durum.DurumAd as Durum,\r\n" +
                "    Dolap.DolapAd as Dolap,\r\n" +
                "    Raf.RafAd as Raf,\r\n" +
                "    Kutu.KutuAd as Kutu,\r\n" +
                "    Bolme.BolmeAd as Bolme,\r\n" +
                "    UrunKutu.UrunAdet as UrunAdet,\r\n" +
                "    UrunKutu.StokMiktari as Stok\r\n" +
                "    from UrunKutu\r\n" +
                "    inner join Kategori on Kategori.KategoriId= UrunKutu.KategoriId\r\n" +
                "    inner join Konum on Konum.KonumId= UrunKutu.KonumId\r\n" +
                "	inner join Durum on Durum.DurumId = UrunKutu.DurumId\r\n" +
                "    inner join Bolme on Bolme.BolmeId = UrunKutu.BolmeId\r\n" +
                "    inner join Kutu on Kutu.KutuId = Bolme.KutuId\r\n" +
                "    inner join Raf on Raf.RafId = Kutu.RafId\r\n" +
                "    inner join Dolap on Dolap.DolapId= Raf.DolapId where " + sorgu;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (tablo == "Urun")
                {
                    UrunListe urunListe = new UrunListe
                    {

                        UrunId = Convert.ToInt32(dr["UrunId"]),
                        KategoriAd = dr["Kategori"].ToString(),
                        KonumAd = dr["Konum"].ToString(),
                        UrunAd = dr["Urun"].ToString(),
                        DurumAd = dr["Durum"].ToString(),
                        DolapAd = dr["Dolap"].ToString(),
                        RafAd = dr["Raf"].ToString(),
                        Kutu = "-",
                        Bolme = "-",
                        UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                        StokMiktari = Convert.ToInt32(dr["Stok"])
                    };
                    urunListes.Add(urunListe);
                }
                else if (tablo == "UrunKutu")
                {
                    UrunListe urunListe = new UrunListe
                    {

                        UrunId = Convert.ToInt32(dr["UrunId"]),
                        KategoriAd = dr["Kategori"].ToString(),
                        KonumAd = dr["Konum"].ToString(),
                        UrunAd = dr["Urun"].ToString(),
                        DurumAd = dr["Durum"].ToString(),
                        DolapAd = dr["Dolap"].ToString(),
                        RafAd = dr["Raf"].ToString(),
                        Kutu = dr["Kutu"].ToString(),
                        Bolme = dr["Bolme"].ToString(),
                        UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                        StokMiktari = Convert.ToInt32(dr["Stok"])
                    };
                    urunListes.Add(urunListe);
                } 
            }
            dr.Close();
            _baglanti.Close();
            return urunListes;
        }
        public UrunListe Get(string tablo,string sorgu= null)
        {
            SqlDataReader dr;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            _baglanti.Open();
            if (string.IsNullOrEmpty(sorgu) && tablo == "Urun")
                komut.CommandText = "select \r\n" +
                "Urun.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "Urun.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Urun.UrunAdet as UrunAdet,\r\n" +
                "Urun.StokMiktari as Stok\r\n" +
                "from Urun\r\n" +
                "inner join Kategori on Kategori.KategoriId= Urun.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= Urun.KonumId\r\n" +
                "inner join Raf on Raf.RafId = Urun.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId\r\n" +
                "inner join Durum on Durum.DurumId = Urun.DurumId";
            else if (!string.IsNullOrEmpty(sorgu) && tablo == "Urun")
                komut.CommandText = "select \r\n" +
                "Urun.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "Urun.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Urun.UrunAdet as UrunAdet,\r\n" +
                "Urun.StokMiktari as Stok\r\n" +
                "from Urun\r\n" +
                "inner join Kategori on Kategori.KategoriId= Urun.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= Urun.KonumId\r\n" +
                "inner join Raf on Raf.RafId = Urun.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId\r\n" +
                "inner join Durum on Durum.DurumId = Urun.DurumId\r\n" +
                "where " + sorgu;
            else if (string.IsNullOrEmpty(sorgu) && tablo == "UrunKutu")
                komut.CommandText = "select\r\n" +
                "UrunKutu.UrunId as UrunId,\r\n" +
                "Kategori.KategoriAd as Kategori,\r\n" +
                "Konum.KonumAd as Konum,\r\n" +
                "UrunKutu.UrunAd as Urun,\r\n" +
                "Durum.DurumAd as Durum,\r\n" +
                "Dolap.DolapAd as Dolap,\r\n" +
                "Raf.RafAd as Raf,\r\n" +
                "Kutu.KutuAd as Kutu,\r\n" +
                "Bolme.BolmeAd as Bolme,\r\n" +
                "UrunKutu.UrunAdet as UrunAdet,\r\n" +
                "UrunKutu.StokMiktari as Stok\r\n" +
                "from UrunKutu\r\n" +
                "inner join Kategori on Kategori.KategoriId= UrunKutu.KategoriId\r\n" +
                "inner join Konum on Konum.KonumId= UrunKutu.KonumId\r\n" +
                "inner join Durum on Durum.DurumId = UrunKutu.DurumId\r\n" +
                "inner join Bolme on Bolme.BolmeId = UrunKutu.BolmeId\r\n" +
                "inner join Kutu on Kutu.KutuId = Bolme.KutuId\r\n" +
                "inner join Raf on Raf.RafId = Kutu.RafId\r\n" +
                "inner join Dolap on Dolap.DolapId= Raf.DolapId";
            else if (!string.IsNullOrEmpty(sorgu) && tablo == "UrunKutu")
                komut.CommandText = "select\r\n" +
                "	UrunKutu.UrunId as UrunId,\r\n" +
                "	Kategori.KategoriAd as Kategori,\r\n" +
                "    Konum.KonumAd as Konum,\r\n" +
                "    UrunKutu.UrunAd as Urun,\r\n" +
                "    Durum.DurumAd as Durum,\r\n" +
                "    Dolap.DolapAd as Dolap,\r\n" +
                "    Raf.RafAd as Raf,\r\n" +
                "    Kutu.KutuAd as Kutu,\r\n" +
                "    Bolme.BolmeAd as Bolme,\r\n" +
                "    UrunKutu.UrunAdet as UrunAdet,\r\n" +
                "    UrunKutu.StokMiktari as Stok\r\n" +
                "    from UrunKutu\r\n" +
                "    inner join Kategori on Kategori.KategoriId= UrunKutu.KategoriId\r\n" +
                "    inner join Konum on Konum.KonumId= UrunKutu.KonumId\r\n" +
                "	inner join Durum on Durum.DurumId = UrunKutu.DurumId\r\n" +
                "    inner join Bolme on Bolme.BolmeId = UrunKutu.BolmeId\r\n" +
                "    inner join Kutu on Kutu.KutuId = Bolme.KutuId\r\n" +
                "    inner join Raf on Raf.RafId = Kutu.RafId\r\n" +
                "    inner join Dolap on Dolap.DolapId= Raf.DolapId where " + sorgu;
            dr = komut.ExecuteReader();
            dr.Read();
            UrunListe urunListe = new UrunListe
            {
                UrunId = Convert.ToInt32(dr["UrunId"]),
                KategoriAd = dr["Kategori"].ToString(),
                KonumAd = dr["Konum"].ToString(),
                UrunAd = dr["Urun"].ToString(),
                DurumAd = dr["Durum"].ToString(),
                DolapAd = dr["Dolap"].ToString(),
                RafAd = dr["Raf"].ToString(),
                UrunAdet = Convert.ToInt32(dr["UrunAdet"]),
                StokMiktari = Convert.ToInt32(dr["Stok"])
            };
            dr.Close();
            _baglanti.Close();
            return urunListe;
        }
    }
}
