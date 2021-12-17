using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ÜrünStok.DataAccess;
using ÜrünStok.Entities;
using ÜrünStok.Formlar;

namespace ÜrünStok.Business
{
    public class UrunManager
    {
        UrunDal _urunDal = new UrunDal();

        public List<Urun> GetAll(string param=null)
        {
            return _urunDal.GetAll(param);
        }
        public Urun Get(string param = null)
        {
            return _urunDal.Get(param);
        }
        public bool Add(Urun urun)
        {            
            if (frmLogin._kullanici.KullaniciYetki == 1 || frmLogin._kullanici.KullaniciYetki == 2)
            {
                _urunDal.Add(urun);
                return true;
            }

            else
            {
                MessageBox.Show("Yönetici ve Kullanıcı Ekleme işlemi yapabilir.");
                return false;
            }
        }
        public bool Delete (int id)
        {            
            if (frmLogin._kullanici.KullaniciYetki == 1)
            {
                _urunDal.Delete(id);
                return true;
            }
            else
            {
                MessageBox.Show("Yönetici Silme işlemi yapabilir.");
                return false;
            }
        }
        public bool Update(Urun urun)
        {            
            if (frmLogin._kullanici.KullaniciYetki == 1)
            {
                _urunDal.Update(urun);
                return true;
            }
            else
            {
                MessageBox.Show("Yönetici Güncelleme işlemi yapabilir.");
                return false;
            }
        }
    }
}
