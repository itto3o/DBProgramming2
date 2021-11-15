using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ConfigManager
    {
        private static ConfigManager instance_ = new ConfigManager();

        private int idx = 0;
        private bool AutoLoad = false;

        public static ConfigManager GetInstance()
        {
            return instance_;
        }
        
        private ConfigManager()
        {
            //initialization
        }

        public bool HasAutoLoad()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERE ID = 1");
            rdr.Read();

            AutoLoad = Convert.ToBoolean(rdr["autoLoad"]);
            return AutoLoad;
        }

        public void SetAutoLoad(bool changeAutoLoad)
        {
            int toIntAutoLoad = 0;

            if (changeAutoLoad)
                toIntAutoLoad = 1;

            else
                toIntAutoLoad = 0;

            string query = "UPDATE DBP_ConfigManager SET autoLoad = " + toIntAutoLoad + "WHERE ID = 1";
            DBManager.GetInstance().update(query);
        }

        public int GetRecentlyUsedListIdx()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERE ID = 1");
            rdr.Read();

            idx = Convert.ToInt32(rdr["recentlyIdx"]);
            return idx;
        }

        public void SetRecentlyUsedListIdx(int changeIdx)
        {
            string query = "UPDATE DBP_ConfigManager SET autoLoad = " + changeIdx + "WHERE ID = 1";
            DBManager.GetInstance().update(query);
        }
    }
}
