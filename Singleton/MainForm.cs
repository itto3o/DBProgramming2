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
        private StudentInfo stuInfo1 = new StudentInfo();
        private StudentInfo stuInfo2 = new StudentInfo();
        private StudentInfo stuInfo3 = new StudentInfo();
        private MajorInfo majorInfo = new MajorInfo();

        private int majorListcurrentIndex = -1;

        public MainForm()
        {
            InitializeValues();
            InitializeComponent();
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
            //clear 한번 해주기
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.Add("남자");
            comboBoxStudent1Gender.Items.Add("여자");

            //clear 한번 해주기
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            //clear 한번 해주기
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.Add("남자");
            comboBoxStudent3Gender.Items.Add("여자");
        }

        //Init - listMajor setting
        public void MajorListSetting()
        {
            //clear 한번 해주기
            listBoxMajorList.Items.Clear();
            //중복 없이 major select
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT DISTINCT major FROM DBP_studentInfo");
            while(rdr.Read())
            {
                listBoxMajorList.Items.Add(rdr["major"].ToString());
            }
        }

        //init - start AutoLoad setting
        public void AutoLoadSetting()
        {
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT * FROM DBP_ConfigManager WHERER ID = 1");
            rdr.Read();

            if (Convert.ToInt32(rdr["autolLoad"]) == 1)
            {
                checkBoxStartAutoLoadStudentInfo.Checked = true;
            }

            else
                checkBoxStartAutoLoadStudentInfo.Checked = false;
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
            MySqlDataReader rdr = DBManager.GetInstance().select("SELECT recentlyIdx FROM DBP_ConfigManager WHERER ID = 1");
            rdr.Read();

            listBoxMajorList.SelectedIndex = Convert.ToInt32(rdr["recentlyIdx"]);

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
        }

        private void checkBoxStartAutoLoadStudentInfo_CheckedChanged(object sender, EventArgs e)
        {
            //바뀐 값으로 Set
            ConfigManager.GetInstance().SetAutoLoad(checkBoxStartAutoLoadStudentInfo.Checked);
        }

        private void checkBoxStartRecentUseMajorInfoPrint_CheckedChanged(object sender, EventArgs e)
        {
            //체크박스에 체크가 되어있다면 바뀔 때마다 저장
            if (checkBoxStartAutoLoadStudentInfo.Checked)
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(majorListcurrentIndex);

            //false로 바뀌었을 경우 recentIndex를 -1로 설정(초기화)
            else
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(-1);

        }

        private void listBoxMajorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            majorListcurrentIndex = listBoxMajorList.SelectedIndex;
            if (checkBoxStartRecentUseMajorInfoPrint.Checked)
                ConfigManager.GetInstance().SetRecentlyUsedListIdx(majorListcurrentIndex);
        }
    }
}
