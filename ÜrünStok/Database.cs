using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜrünStok
{

    class Database
    {
    }

    interface IDatabase
    {        
        void Add();
        void Delete();
        void Update();
    }
    class SqlServer : IDatabase
    {

        public void Add()
        {
            
        }

        public void Delete()
        {
            
        }

        public void Update()
        {
           
        }
    }

}
