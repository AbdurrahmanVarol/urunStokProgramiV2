using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ÜrünStok.Class;
using ÜrünStok.Entities;
using ÜrünStok.Formlar;

namespace ÜrünStok.Business
{
    public class UrunKutuManager
    {
        UrunKutuDal _urunKutuDal = new UrunKutuDal();

        public List<UrunKutu> GetAll(string param = null)
        {
            return _urunKutuDal.GetAll(param);
        }
        public UrunKutu Get(string param = null)
        {
            return _urunKutuDal.Get(param);
        }
        public bool Add(UrunKutu urun)
        {
            if (frmLogin._kullanici.KullaniciYetki == 1 || frmLogin._kullanici.KullaniciYetki == 2)
            {
                _urunKutuDal.Add(urun);
                return true;
            }
                
            else
            {
                MessageBox.Show("Yönetici ve Kullanıcı Ekleme işlemi yapabilir.");
                return false;
            }
               
                             
        }
        public bool Delete(int id)
        {
            if (frmLogin._kullanici.KullaniciYetki == 1)
            {
                _urunKutuDal.Delete(id);
                return true;
            }
                
            else
            {
                MessageBox.Show("Yönetici silme işlemi yapabilir.");
                return false;
            }
                
        }
        public bool Update(UrunKutu urun)
        {
            if (frmLogin._kullanici.KullaniciYetki == 1)
            {
                _urunKutuDal.Update(urun);
                return true;
            }                
            else
            {
                MessageBox.Show("Yönetici silme işlemi yapabilir.");
                return false;
            }
                
        }
    }
}
