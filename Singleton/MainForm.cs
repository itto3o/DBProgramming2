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

namespace Singleton
{
    public partial class MainForm : Form
    {
        //외부에서 접근이 가능하도록 public static으로 선언한다.
        public static MainForm mainForm;

        private StudentInfo stuInfo1 = new StudentInfo();
        private StudentInfo stuInfo2 = new StudentInfo();
        private StudentInfo stuInfo3 = new StudentInfo();
        private MajorInfo majorInfo = new MajorInfo();

        //현재 전공리스트에서 무엇을 가리키고 있는지를 저장할 변수이다.
        private int majorListcurrentIndex = -1;

        public MainForm()
        {
            //InitializeComponent()함수를 맨 먼저 해야 control들이 생성이됨...(이거 먼저 안하면 접근 아예 못함)
            InitializeComponent();
            InitializeValues();
            //mainForm객체가 this(현재 mainform)를 가리키도록 한다.
            mainForm = this;
        }

        public void InitializeValues()
        {
            //comboBox setting
            comboBoxSetting();

            //listMajor setting
            MajorListSetting();

            //start AutoLoad setting
            AutoLoadSetting();

            //start recently Used Index setting
            RecentIndex();


            //init 후에 recentlyUsedIndex checkbox가 check되어 있다면 최근 index로 load,
            //autoLoad만 check되어 있다면 index가 0으로 load
            //둘다 check되어있지 않으면 아무것도 ㄴㄴ
            if (checkBoxStartRecentUseMajorInfoPrint.Checked)
                StudentInfoLoad(majorListcurrentIndex);
            else if (checkBoxStartAutoLoadStudentInfo.Checked)
                StudentInfoLoad(0);
        }

        //Init - comboBox setting
        public void comboBoxSetting()
        {
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Add("남자");
            comboBoxStudent3Gender.Items.Add("여자");
        }

        //Init - listMajor setting
        public void MajorListSetting()
        {
            //studentInfo에서 값을 불러와서 하면 테이블 안에 값이 지워지고 저장될 때 major도 달라지기 때문에 majorlist의 순서가 바뀔 수 있음
            //==>studentInfo가 아닌 majorInfo table을 하나 만들어서 그곳에서 값을 불러와야 할듯
            //중복 없이 major select
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT major FROM DBP_majorInfo");
            if (rdr.IsClosed) return;

            while(rdr.Read())
            {
                //listBox에 불러온 값들을 넣는다.
                listBoxMajorList.Items.Add(rdr["major"].ToString());
            }
            rdr.Close();
        }

        //init - start AutoLoad setting
        public void AutoLoadSetting()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERE ID = 1");
            if (rdr.IsClosed) return;

            rdr.Read();
            if (Convert.ToInt32(rdr["autoLoad"]) == 1)
            {
                checkBoxStartAutoLoadStudentInfo.Checked = true;
            }

            else
                checkBoxStartAutoLoadStudentInfo.Checked = false;

            rdr.Close();
        }

        /*
         * 잠시만 생각해보자
         * 자 configManager 테이블에는 recentIndex밖에 없어
         * 그래서 체크 유무를 확인하기 위해서 form창을 닫을 때 체크박스에 체크가 안되어 있다면
         * index를 -1로 줘서 아무것도 선택하지 않은 것으로 초기화 시켰고
         * 
         * checkbox를 change 할 경우
         * 1) true -> false : 이 경우도 -1로 바꿔야 할까? ==> 정답은 아니. 어차피 폼이 닫힐때 여부를 판단하니까
         * 만약에 바꾸게 된다면? 음... 상관 없을 것 같아.
         * 
         * 사실 전역변수?(private)로 currentIndex를 선언해서 selected가 될때마다 이 변수만 바뀌고
         * check change가 일어났을 때는 table update를 하면 되지 않을까?
         * false로 바뀔 때는 -1로 설정해서 init할 때 -1이면 false로 불러오면 되니까
         * 값이 있다면 그거 먼저 selected되었다고 표시하고 true로 바꾸면 문제 없을듯? ==> ㅇㅋ 이런식으로 하자.
         * 
         * false로 바뀔 때 -1로 설정하는걸 뭘로 해야 할까
         *  DB안의 index 데이터 값을 바꿔야겠지?
         *  왜냐면 currentIndex 변수는 계속 값을 가지고 있어야 다시 check될 때 -1이 아닌 최근 값을 넣을 수 있으니까
         *  
         *  엇 근데 check될 때만 저장하면
         *  check하고 나서 많이 변경 한 뒤에 그냥 꺼버리면 그 값은 없어지자나(변수니까)
         *  ==>listbox값이 바뀔 때마다 저장해야 하나? 음.. 아니면 둘다..? ==>true면 둘다 저장하자 
         *  뭔가 그러면 currentIdx가 없어도 될 것 같아서 폼이 꺼질때 false면 -1로 설정하려고 했던건데 음
         *  
         */
        //init - start recently Used Index setting
        public void RecentIndex()
        {
            //먼저 저장된 idx값을 불러와서 listbox에서 select해두고
            //checkbox를 check하면 check되어있을 때만 db값이 바뀌니까 이러면 될듯
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT recentlyIdx FROM DBP_ConfigManager WHERE ID = 1");
            if (rdr.IsClosed) return;

            rdr.Read();

            //저장해뒀던 index 값을 읽어온다.
            listBoxMajorList.SelectedIndex = Convert.ToInt32(rdr["recentlyIdx"]);
            rdr.Close();

            //만약에 -1이면 check가 안된 상태로 끝났었다는 의미 ==> 255줄에서 checkbox가 false로 바뀌면 -1을 저장하기 때문
            if (listBoxMajorList.SelectedIndex == -1)
            {
                checkBoxStartRecentUseMajorInfoPrint.Checked = false;
            }
            else
                checkBoxStartRecentUseMajorInfoPrint.Checked = true;
        }

        /*
         * 엇 전공리스트에서 더블클릭하면? 학생정보가 불러와지고
         * 전공리스트의 item을 클릭하고 불러오기를 눌러야 불러와지는 거겠지? ==> 클릭 안했으면 전공선택 먼저 하라고 messagebox.show()
         * 그냥 불러오기 버튼을 누르면 음.. 학생마다 전공이 다를 수 잇으니까(전공 리스트에 선택되게 나타나야 하니까)
         * 그러면 전공리스트의 index를 파라미터로 받아와야겠네
         * 
         * 잠시만 그럼 프로그램 시작시 자동으로 불러오는 flag는 어케해야되지
         * 0...일까? 0으로 해두자 잠시만 그러면
         * autoload만 check한 경우 : index 0으로 불러오기? 아니면 전공없이 ID가 1~3인거 불러오기..?
         * 최근 major flag만 check한 경우는 어케 해야되지 뭐지 전공리스트를 최근사용순으로 정렬하라는 건 아닐 것 같은데 음..
         * 밑에 꺼랑 동일하려나..? 어... ;ㅅ; 여쭤보고싶다 일단 밑에꺼랑 같은 맥락인 것 같아
         * 두개 다 check한거면 index recently로 불러오기면 될 것 같은데
         */
        
        //student정보 불러오는 함수
        public void StudentInfoLoad(int majorIndex)
        {
            //파라미터로 받아온 majorlist의 index를 나타내주고 그 전공의 학생정보를 가져옴
            listBoxMajorList.SelectedIndex = majorIndex;
            string query = "SELECT * FROM DBP_studentInfo WHERE major = '" + listBoxMajorList.SelectedItem + "'";
            MySqlDataReader rdr = DBManager.GetInstance().select(query);
            

            //count를 해서 개수만큼만 쓸까 아니면
            //null이면 return하는 코드를 짤까

            //오 뭔가..! switch문으로 count에 따라 textbox123을 정할 수 있지 않을까
            //break문을 안써서 3>2>1 순으로 하나씩만 넣으면 될듯?

            //major가 지금 선택된 전공인 학생 수
            string countQuery = "SELECT COUNT(*) as cnt FROM DBP_studentInfo WHERE major = '" + listBoxMajorList.SelectedItem + "'";
            MySqlDataReader reader = DBManager.GetInstance().select(countQuery);

            reader.Read();
            int cnt = Convert.ToInt32(reader["cnt"]);
            //break를 안 걸면 되는 줄 알았는데 오류가 뜨고 찾아보니까 goto를 쓰면 될 것 같다.
            //==> 굳이 3 2 1 순서로 안해도 됐었네

            //근데 이렇게 해보니까 발생하는 문제점
            //전공이 아닌 학생들이 남아있음
            //switch문 전에 한번 클리어 해주면 될듯..?

            //clear
            textBoxStudent1Name.Text = "";
            textBoxStudent1Sid.Text = "";
            comboBoxStudent1Gender.Text = "";

            textBoxStudent2Name.Text = "";
            textBoxStudent2Sid.Text = "";
            comboBoxStudent2Gender.Text = "";

            textBoxStudent3Name.Text = "";
            textBoxStudent3Sid.Text = "";
            comboBoxStudent3Gender.Text = "";

            switch (cnt)
            {
                //3일 때 3번자리부터 채워지다보니 1번이랑 3번이 자리가 바뀌긴 하지만
                //1명일 때 3번자리만 채워지는 것보단 나은 것 같다
                case 3:
                    rdr.Read();
                    textBoxStudent3Name.Text = rdr["name"].ToString();
                    textBoxStudent3Sid.Text = rdr["sid"].ToString();
                    comboBoxStudent3Gender.Text = rdr["gender"].ToString();
                    goto case 2;

                case 2:
                    rdr.Read();
                    textBoxStudent2Name.Text = rdr["name"].ToString();
                    textBoxStudent2Sid.Text = rdr["sid"].ToString();
                    comboBoxStudent2Gender.Text = rdr["gender"].ToString();
                    goto case 1;

                case 1:
                    rdr.Read();
                    textBoxStudent1Name.Text = rdr["name"].ToString();
                    textBoxStudent1Sid.Text = rdr["sid"].ToString();
                    comboBoxStudent1Gender.Text = rdr["gender"].ToString();
                    break;

                case 0:
                    break;
            }
            rdr.Close();
            reader.Close();
        }

        private void checkBoxStartAutoLoadStudentInfo_CheckedChanged(object sender, EventArgs e)
        {
            //바뀐 값으로 Set
            ConfigManager.GetInstance().SetAutoLoad(checkBoxStartAutoLoadStudentInfo.Checked);
        }

        private void checkBoxStartRecentUseMajorInfoPrint_CheckedChanged(object sender, EventArgs e)
        {
            //체크박스에 체크가 되어있다면 바뀔 때마다 저장
            if (checkBoxStartRecentUseMajorInfoPrint.Checked)
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(majorListcurrentIndex);

            //false로 바뀌었을 경우 recentIndex를 -1로 설정(초기화)
            else
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(-1);

        }

        private void listBoxMajorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //일단 listbox의 값이 바뀔 때마다 변수에 저장
            majorListcurrentIndex = listBoxMajorList.SelectedIndex;

            //최근전공사용 checkbox가 check되어 있을 때만 저장
            if (checkBoxStartRecentUseMajorInfoPrint.Checked)
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(majorListcurrentIndex);
        }

        //majorlist에서 major를 더블클릭해도 학생정보가 보이게끔
        //list의 빈 곳을 클릭할 경우는 x
        private void listBoxMajorList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 인덱스를 저장할 변수
            int selectedIndex = -1; 
            
            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            //IndexFromPoint : 매개변수로 전달된 좌표에 항목이 존재하면 해당 항목의 인덱스를 반환하고 빈 공간인 경우는 - 1을 반환
            selectedIndex = listBoxMajorList.IndexFromPoint(point);

            // 빈 공간이 아닌 곳을 더블클릭 했을 때 그 전공에 맞는 학생정보 로드
            if (selectedIndex != -1)
            {
                listBoxMajorList.SelectedIndex = selectedIndex;
                StudentInfoLoad(selectedIndex);
            }

        }

        private void buttonMajorAdd_Click(object sender, EventArgs e)
        {
            majorInfo.Add();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            //StudentInfo class에서는 객체가 누군지 모르니까 현재 정보를 보내줘야 함
            //차라리 객체 자체를 보내는게 좋을까 음...
            stuInfo1.AddOrUpdate(textBoxStudent1Name.Text, textBoxStudent1Sid.Text, comboBoxStudent1Gender.Text, listBoxMajorList.SelectedItem.ToString());
        }

        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            stuInfo1.Delete(textBoxStudent1Sid.Text);

            //삭제 후 clear
            textBoxStudent1Name.Text = "";
            textBoxStudent1Sid.Text = "";
            comboBoxStudent1Gender.Text = "";
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            stuInfo1.AddOrUpdate(textBoxStudent2Name.Text, textBoxStudent2Sid.Text, comboBoxStudent2Gender.Text, listBoxMajorList.SelectedItem.ToString());
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            stuInfo2.Delete(textBoxStudent2Sid.Text);

            textBoxStudent2Name.Text = "";
            textBoxStudent2Sid.Text = "";
            comboBoxStudent2Gender.Text = "";
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            stuInfo1.AddOrUpdate(textBoxStudent3Name.Text, textBoxStudent3Sid.Text, comboBoxStudent3Gender.Text, listBoxMajorList.SelectedItem.ToString());
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            stuInfo3.Delete(textBoxStudent3Sid.Text);

            textBoxStudent3Name.Text = "";
            textBoxStudent3Sid.Text = "";
            comboBoxStudent3Gender.Text = "";
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            if (listBoxMajorList.SelectedIndex != -1)
            {
                StudentInfoLoad(listBoxMajorList.SelectedIndex);
            }

            //전공 리스트에 아무런 값이 선택되지 않았다면 messageBox 출력
            //어떤 학생정보를 불러와야할지... 모르겠기 때문...
            else
                MessageBox.Show("불러올 major를 먼저 선택해주세요");
        }
    }
}
