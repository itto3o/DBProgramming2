using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();

        private DBManager()
        {
            //initialization
        }

        public static DBManager GetInstance()
        {
            return instance_;
        }

        private string connection_string = "";

        public void insert(string query)
        {

        }

        public void update(string query)
        {

        }
    }
}
