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
    public partial class MainForm : Form
    {
        private int admin = 0;
        private string userID = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) as cnt FROM DBP_QUIZ_user WHERE userID = '" + textBoxUserID.Text + "' AND userPW = '" + textBoxUserPW.Text + "'";
            DataTable dt = DBManager.GetInstance().select(query);
            DataRow dtRow = dt.Rows[0];
            if (Convert.ToInt32(dtRow["cnt"]) == 0)
            {
                MessageBox.Show("로그인 실패");
                textBoxUserID.Text = "";
                textBoxUserPW.Text = "";
            }

            else
            {
                labelWelcome.Text = textBoxUserID.Text + "님 환영합니다.";
                string queryAdminCheck = "SELECT adminCheck FROM DBP_QUIZ_user WHERE userID = '" + textBoxUserID.Text + "' AND userPW = '" + textBoxUserPW.Text + "'";
                DataTable dt2 = DBManager.GetInstance().select(queryAdminCheck);
                DataRow dtRow2 = dt2.Rows[0];
                if (Convert.ToInt32(dtRow2["adminCheck"]) == 1)
                {
                    admin = 1;
                    adminGridView();
                }
                userID = textBoxUserID.Text;
            }

        }

        private void adminGridView()
        {
            DataTable dtUserDaily = DBManager.GetInstance().select("SELECT buyerID, date, COUNT(*) as 판매량, SUM(menuPrice) as 판매액 FROM DBP_QUIZ_sale GROUP BY buyerID, date");
            dataGridViewUserDay.DataSource = dtUserDaily;
            DataTable dtMenuDaily = DBManager.GetInstance().select("SELECT menuName, date, COUNT(*) as 판매량, SUM(menuPrice) as 판매액 FROM DBP_QUIZ_sale GROUP BY menuName, date");
            dataGridViewMenuDaily.DataSource = dtMenuDaily;
            DataTable dtMenuMonthly = DBManager.GetInstance().select("SELECT menuName, MONTH(date) as 월, COUNT(*) as 판매량, SUM(menuPrice) as 판매액 FROM DBP_QUIZ_sale GROUP BY menuName, MONTH(date)");
            dataGridViewMenuMonthly.DataSource = dtMenuMonthly;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSunDae_Click(object sender, EventArgs e)
        {

            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_sale VALUES(NULL, 1, '순대국밥', 6000, '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "')");
        }

        private void buttonDaesi_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_sale VALUES(NULL, 2, '돼지국밥', 6000, '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "')");

        }

        private void buttonDdaro_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_sale VALUES(NULL, 3, '따로국밥', 6000, '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "')");
        }
    }
}
