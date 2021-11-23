using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_Quiz
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();
        private string connection_string = "Server={serverIP};Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8";

        private DBManager()
        {
            //initialization
        }

        public static DBManager GetInstance()
        {
            return instance_;
        }

        //cmd.ExecuteNonQuery()를 쓰는 insert, delete, update에 사용될 함수
        //반복되는게 싫어서 만들었다.
        private void nonQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void insert(string query)
        {
            nonQuery(query);
        }

        public void update(string query)
        {
            nonQuery(query);

        }

        //음... rdr을 반환하면 MainForm에서 rdr이 자동으로 닫혀.. ==> conn이 닫혀서 그런 것 같아.
        //그래서 using을 안쓰고 CommandBehavior.CloseConnection으로 하면 rdr이 닫힐 때 conn이 닫힌대.
        public DataTable select(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                return dt;
            }
        }

        public void delete(string query)
        {
            nonQuery(query);
        }
    }
}
