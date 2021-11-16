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

        //AutoLoad의 bool 값을 확인하는 함수
        public bool HasAutoLoad()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERE ID = 1");
            rdr.Read();

            AutoLoad = Convert.ToBoolean(rdr["autoLoad"]);
            return AutoLoad;
        }

        //AutoLoad를 설정하는 함수도 있으면 좋을 것 같아서 만들었다.
        public void SetAutoLoad(bool changeAutoLoad)
        {
            int toIntAutoLoad = 0;

            //바꿀 autoLoad값이 true면 1의 값을 저장한다.
            if (changeAutoLoad)
                toIntAutoLoad = 1;

            else
                toIntAutoLoad = 0;

            //DB의 autoLoad의 데이터 형식은 boolean이 아닌 tinyInt이므로 0, 1로 구별한다.
            string query = "UPDATE DBP_ConfigManager SET autoLoad = " + toIntAutoLoad + " WHERE ID = 1";
            DBManager.GetInstance().update(query);
        }

        //최근 사용 index를 읽어온다.
        public int GetRecentlyUsedListIdx()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERE ID = 1");
            rdr.Read();

            idx = Convert.ToInt32(rdr["recentlyIdx"]);
            return idx;
        }

        //index를 set하는 함수도 있으면 좋을 것 같아 만들었다.
        public void SetRecentlyUsedListIdx(int changeIdx)
        {
            string query = "UPDATE DBP_ConfigManager SET recentlyIdx = " + changeIdx + " WHERE ID = 1";
            DBManager.GetInstance().update(query);
        }
    }
}
