using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagementDB
{
    public partial class Form1 : Form
    {
        //DB접속 정보
        string strconn = "Server=27.96.130.41;Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8";
        //InitValues()에서 changed 이벤트가 일어나도 값이 저장되지 않도록 flag 설정
        bool loadflag = false;

        public Form1()
        {
            InitializeComponent();
            InitValues();
        }

        //초기화 함수
        private void InitValues()
        {
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Add("남자");
            comboBoxStudent3Gender.Items.Add("여자");

            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent3Name.Text = "학생정보 없음";

            //학생 정보 자동 로드의 checkbox를 확인해서 만약 체크되어있다면 load
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                //studentAutoLoad 테이블의 flag를 확인해서 1이면 checkbox에 체크하고 load한다
                string query = "select * from studentAutoLoad WHERE ID = 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                if(Convert.ToInt32(rdr["flag"]) == 1)
                {
                    checkBoxAutoLoad.Checked = true;
                    studentLoad();
                }
                else
                {
                    checkBoxAutoLoad.Checked = false;
                }
            }
        }

        //현재 저장된 학생 수를 보여주는 함수
        //학생 수는 sid를 기준으로 =, sid가 공백이거나 NULL인 것은 빼고 count한다.
        private void printCount()
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select count(sid) from student where sid != '' AND sid IS NOT NULL;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //MySqlDataReader rdr = cmd.ExecuteReader();

                //int index = Convert.ToInt32(rdr["count(sid)"]);
                int index = Convert.ToInt32(cmd.ExecuteScalar());

                labelCurrentSaveStudent.Text = "현재 저장된 학생수: " + index;
            }
        }

        //저장된 정보를 불러오는 함수
        private void studentLoad()
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select * from student";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                //학생1 학생2 학생3을 따로 불러올 방법이 2차원배열 말고는 생각이 나질 않아서
                //read()를 반복문에 넣지 않고 따로따로 호출했다.
                rdr.Read();
                textBoxStudent1Name.Text = rdr["name"].ToString();
                textBoxStudent1ID.Text = rdr["sid"].ToString();
                comboBoxStudent1Gender.Text = rdr["gender"].ToString();
                textBoxStudent1Memo.Text = rdr["memo"].ToString();

                rdr.Read();
                textBoxStudent2Name.Text = rdr["name"].ToString();
                textBoxStudent2ID.Text = rdr["sid"].ToString();
                comboBoxStudent2Gender.Text = rdr["gender"].ToString();
                textBoxStudent2Memo.Text = rdr["memo"].ToString();

                rdr.Read();
                textBoxStudent3Name.Text = rdr["name"].ToString();
                textBoxStudent3ID.Text = rdr["sid"].ToString();
                comboBoxStudent3Gender.Text = rdr["gender"].ToString();
                textBoxStudent3Memo.Text = rdr["memo"].ToString();

                rdr.Close();

            }
            //load한 후에 flag를 true로 바꾸고 현재 저장 수 print
            loadflag = true;
            printCount();
        }
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            studentLoad();
        }

        //학생정보를 저장한다.
        private void studentSave()
        {
            //loadflag가 false라면 return, 만약 db에 데이터가 아직 없다면
            //이 부분을 주석처리하고, changed 이벤트의 studentSave를 모두 주석처리 한 후 먼저 데이터를 저장해야한다.
            if (loadflag == false) return;
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                //만약 불러온 값이 모두 null이라면 저장==>근데 만약 삭제한거면 2를 불러올수도있잖아, 불러온 값이 있다면 update?
                //기준을 학번으로 삼아야 하나? 근데.. 학번을 수정하는 거면..? ==>일단 학번수정은 안하는걸로 하자 ==>근데 삭제할때 공백이 되니까 중복발생

                //id가 1인 값을 불러왔을때 만약에 그 값이 없다면 저장, 있다면 수정 delete 한 뒤는 수정
                //string query = "SELECT * FROM student WHERE id = 1";
                //string str = "('" + textBoxStudent1Name.Text + "', '" + textBoxStudent1ID.Text + "', '" + comboBoxStudent1Gender.Text + "', '" + textBoxStudent1Memo.Text + "')";
                //string query = "INSERT INTO student(name, id, gender, memo) values" + str;

                //mysql> insert into t1  values (NULL, 'ENTRY4', 24) ON DUPLICATE KEY UPDATE size = 24;
                //그러면 그냥 위에꺼 그대로,
                string str = "(1, '" + textBoxStudent1Name.Text + "', '" + textBoxStudent1ID.Text + "', '" + comboBoxStudent1Gender.Text + "', '" + textBoxStudent1Memo.Text + "')";

                //모두 다 저장을 할지, 아니면 따로 버튼마다저장을 할지 고민을 해봐야함. 근데 기능을 동일하게 하라고 해서 약간고민 해봐야.. ㅇㅇ...
                //저장은 다 하고 삭제는 따로 하자
                string query = "insert into student values" + str + "ON DUPLICATE KEY UPDATE name = values(name), sid = values(sid), gender = values(gender), memo = values(memo)";

                string str2 = "(2, '" + textBoxStudent2Name.Text + "', '" + textBoxStudent2ID.Text + "', '" + comboBoxStudent2Gender.Text + "', '" + textBoxStudent2Memo.Text + "')";
                string query2 = "insert into student values" + str2 + "ON DUPLICATE KEY UPDATE name = values(name), sid = values(sid), gender = values(gender), memo = values(memo)";

                string str3 = "(3, '" + textBoxStudent3Name.Text + "', '" + textBoxStudent3ID.Text + "', '" + comboBoxStudent3Gender.Text + "', '" + textBoxStudent3Memo.Text + "')";
                string query3 = "insert into student values" + str3 + "ON DUPLICATE KEY UPDATE name = values(name), sid = values(sid), gender = values(gender), memo = values(memo)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlCommand cmd3 = new MySqlCommand(query3, conn);

                //결과값이 없을때 사용
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
            }
            printCount();
        }
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            studentSave();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            studentSave();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            studentSave();
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            //변경사항을 바꿔주면 어차피 저장이 되니까
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.Text = "";
            textBoxStudent1Memo.Text = "";
            printCount();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.Text = "";
            textBoxStudent2Memo.Text = "";
            printCount();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.Text = "";
            textBoxStudent3Memo.Text = "";
            printCount();
        }

        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            //얘는 따로 해야할 것 같은데 이거를 파일로 저장해야하나 아니면 db에 테이블 하나 따로 만들어야하나..
            //파일저장이 좋긴한데... 왠지 파일쓰면 안될것 같기도하고
            //파일이 안된다면 디비에 하는게 맞긴하지만 
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "";

                //flag가 0이면 1로, 1이면 0으로
                if(checkBoxAutoLoad.Checked)
                {
                    query = "UPDATE studentAutoLoad SET flag = 1 WHERE ID = 1";
                }
                else
                    query = "UPDATE studentAutoLoad SET flag = 0 WHERE ID = 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    

        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent1Memo_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent2Name_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent2ID_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void comboBoxStudent2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent2Memo_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent3Name_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent3ID_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void comboBoxStudent3Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentSave();
        }

        private void textBoxStudent3Memo_TextChanged(object sender, EventArgs e)
        {
            studentSave();
        }
    }
}
