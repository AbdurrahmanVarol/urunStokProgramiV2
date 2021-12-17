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
    public class RafManager
    {
        RafDal _rafDal = new RafDal();

        public List<Raf> GetAll(string param = null)
        {
            return _rafDal.GetAll(param);
        }
        public Raf Get(string param = null)
        {
            return _rafDal.Get(param);
        }
        public bool Add(Raf raf)
        {
            if (frmLogin._kullanici.KullaniciYetki == 1 || frmLogin._kullanici.KullaniciYetki == 2)
            {
                _rafDal.Add(raf);
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
            if (frmLogin._kullanici.KullaniciYetki == 1 || frmLogin._kullanici.KullaniciYetki == 2)
            {
                _rafDal.Delete(id);
                return true;
            }
            else
            {
                MessageBox.Show("Yönetici ve Kullanıcı Ekleme işlemi yapabilir.");
                return false;
            }
        }
        public void Update(Raf raf)
        {
            _rafDal.Update(raf);
        }
    }
}
