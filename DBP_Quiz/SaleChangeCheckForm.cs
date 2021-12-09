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
    public partial class SaleChangeCheckForm : Form
    {
        //음.. 일자별로 볼 수 있게 할까 아니면 일일 유저별?
        //약간 날짜를 선택하면 그 날짜에 판매한 것 중에서 변경내역 띄우게?
        //근데 수정사항 반영을 어떻게 하지 그냥 취소까지 보여주면 되나..?
        //아니면 취소된건 -해서? ==> 이걸 테이블에 나타낼 수 있을까? 테이블끼리 연산이 되나..?
        //일일별? 유저별? 뭔가 일일별은 잘 안될것 같고

        //어떻게 변경 됐는지
        public SaleChangeCheckForm()
        {
            InitializeComponent();
            setValues();
        }
        private void setValues()
        {
            comboBoxUserList.Items.Clear();

            DataTable dataTableUser = DBManager.GetInstance().select("SELECT * FROM DBP_QUIZ_user");
            foreach(DataRow dataRowUser in dataTableUser.Rows)
            {
                //만약 관리자라면 continue, 목록표시x
                //오 관리자가 한명이 아닐때 유용하겠네 adminCheck (근데 그냥 관리자 테이블을 따로 만드는게 쿨럭쿨럭)
                if (Convert.ToInt32(dataRowUser["adminCheck"]) == 1)
                    continue;

                comboBoxUserList.Items.Add(dataRowUser["userID"].ToString());
            }
        }

        private void comboBoxUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //날짜별로 groupby해야할까? 음... 어케나오는지 모르겠넹 날짜별로 하는게 맞아보이긴해 날짜별, 메뉴이름별?
            //sale 테이블엔 메뉴가 ID로 들어가있어서 join 필요
            //select *
            //from sale as s
            //join menu as m
            //on s.menuId = m.id
            //where s.representativeUserID = comboBoxUserList.SelectedItems.Tostring()
            //비고가 없다는 건 아무런 수정도 없었다는 뜻
            //      AND s.note is NULL ;
            //GROUP BY s.representativeUserID, m.name, m.price, s.quantity, s.date
            string item = comboBoxUserList.SelectedItem.ToString();
            string queryNoteISNULL = "SELECT s.representativeUserID as userID, m.name as menuName, m.price as menuPrice, s.quantity as 수량, s.date FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID WHERE s.representativeUserID = '" + item + "' AND s.note is NULL GROUP BY s.representativeUserID, m.name, m.price, s.quantity, s.date";
            DataTable dataTableSaleChangeBefore = DBManager.GetInstance().select(queryNoteISNULL);
            dataGridViewSaleChangeBefore.DataSource = dataTableSaleChangeBefore;

            string queryNote = "SELECT s.representativeUserID as userID, m.name as menuName, m.price as menuPrice, s.quantity as 수량, s.date, s.note as 비고 FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID WHERE s.representativeUserID = '" + item + "' GROUP BY s.representativeUserID, m.name, m.price, s.quantity, s.date, s.note";
            DataTable dataTableSaleChangeAfter = DBManager.GetInstance().select(queryNote);
            dataGridViewSaleChangeAfter.DataSource = dataTableSaleChangeAfter;
        }
    }
}
