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
    public class LogManager
    {
        LogDal _logDal = new LogDal();

        public List<Log> GetAll(string param = null)
        {
            return _logDal.GetAll(param);
        }
        public Log Get(string param = null)
        {
            return _logDal.Get(param);
        }
        public void Add(Log log)
        {
            _logDal.Add(log);
        }
        public void Delete(int id)
        {
            if (frmLogin._kullanici.KullaniciYetki == 1)
                _logDal.Delete(id);
            else
                MessageBox.Show("Sadece yönetici kayıt silme işlemi yapabilir.");
        }
        public void Update(Log log)
        {
            _logDal.Update(log);
        }
    }
}
