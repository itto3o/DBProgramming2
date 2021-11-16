using MySql.Data.MySqlClient;

namespace Singleton
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();
        private string connection_string = "Server=27.96.130.41;Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8";

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
        public MySqlDataReader select(string query)
        {
            //using으로 DB를 open하고 MainForm에서 rdr을 받으면 using을 벗어날 때 conn이 닫히면서 rdr도 close되니까 using사용을 하지 않는다.
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return rdr;
        }

        public void delete(string query)
        {
            nonQuery(query);
        }
    }
}
