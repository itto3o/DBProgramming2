using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Quiz
{
    public partial class MenuChangeCheckForm : Form
    {
        //콤보박스에서 선택을 하면 선택한 메뉴의 변경 정보를 모두 load ==> 이렇게하면 원래정보 모두 다 보임
        public MenuChangeCheckForm()
        {
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            //일단 한번 클리어
            comboBoxMenuList.Items.Clear();

            //모든 메뉴 이름 넣기
            DataTable dataTableMenu = DBManager.GetInstance().select("SELECT * FROM DBP_QUIZ_menu");
            foreach(DataRow dataRowMenu in dataTableMenu.Rows)
            {
                comboBoxMenuList.Items.Add(dataRowMenu["name"].ToString());
            }
        }

        private void comboBoxMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //콤보박스 index는 0부터 시작이니까 menuID는 +1
            int menuID = comboBoxMenuList.SelectedIndex + 1;

            DataTable dataTableMenuChange = DBManager.GetInstance().select("SELECT * FROM DBP_QUIZ_menuChange WHERE menuID = " + menuID);
            dataGridViewMenuChangeList.DataSource = dataTableMenuChange;
        }
    }
}
