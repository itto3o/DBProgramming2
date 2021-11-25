using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public MainForm(string userID, int adminCheck)
        {
            InitializeComponent();
            this.userID = userID;
            this.admin = adminCheck;
            welcome();
        }
        private void welcome()
        {
            if (admin == 1)
            {
                labelWelcome.Text = "관리자님 환영합니다.";
                adminGridView();
            }

            else
            {
                LogRecording_login();
                labelWelcome.Text = userID + "님 환영합니다.";
                userView();
            }
        }

        private void LogRecording_login()
        {
            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_userLog VALUES(NULL, 'login', '" + userID + "', now())");
        }

        private void LogRecording_logout()
        {
            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_userLog VALUES(NULL, 'logout', '" + userID + "', now())");
        }

        private void userView()
        {
            menuStripAdmin.Visible = false;
            labelAdminView.Visible = false;
            dataGridViewUserDay.Visible = false;
            dataGridViewMenuDaily.Visible = false;
            dataGridViewMenuMonthly.Visible = false;
            LoadMenu();
            this.Height = 450;
        }

        private void adminGridView()
        {
            labelCasherView.Visible = false;

            //생각을 해봤는데 메뉴를 동적으로 생성해야하지 않을까 메뉴 수정, 추가가 되니까 아 고칠거 많네...
            DataTable dtUserDaily = DBManager.GetInstance().select("SELECT buyerID, date, COUNT(*) as 판매량, SUM(price) as 판매액 FROM DBP_QUIZ_sale, DBP_QUIZ_menu GROUP BY buyerID, date");
            dataGridViewUserDay.DataSource = dtUserDaily;
            DataTable dtMenuDaily = DBManager.GetInstance().select("SELECT name, date, COUNT(*) as 판매량, SUM(price) as 판매액 FROM DBP_QUIZ_sale, DBP_QUIZ_menu GROUP BY name, date");
            dataGridViewMenuDaily.DataSource = dtMenuDaily;
            DataTable dtMenuMonthly = DBManager.GetInstance().select("SELECT name, MONTH(date) as 월, COUNT(*) as 판매량, SUM(price) as 판매액 FROM DBP_QUIZ_sale, DBP_QUIZ_menu GROUP BY name, MONTH(date)");
            dataGridViewMenuMonthly.DataSource = dtMenuMonthly;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //로그아웃 버튼을 클릭했을 때, 또는 그냥 폼을 닫을 때 로그아웃 기록
            //관리자가 아닐 때만 기록
            if(admin == 0)
                LogRecording_logout();
        }


        //수정, 추가 모두 이 이벤트로 연결
        private void 메뉴수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MenuAddOrUpdateForm menuAddOrUpdateForm = new MenuAddOrUpdateForm()) {
                menuAddOrUpdateForm.ShowDialog();
            }
        }

        //메뉴 동적 생성
        private void LoadMenu()
        {
            DataTable menuTable = DBManager.GetInstance().select("SELECT * FROM DBP_QUIZ_menu");
            int i = 0;

            //한줄씩 읽어서 메뉴 이름
            foreach (DataRow row in menuTable.Rows)
            {
                //메뉴 동적 생성
                PictureBox pictureBoxMenuImage = new PictureBox();
                pictureBoxMenuImage.Location = new Point(i * 170 + 85, 130);
                pictureBoxMenuImage.Width = 170;
                pictureBoxMenuImage.Height = 140;
                Controls.Add(pictureBoxMenuImage);

                Button buttonMenuBuy = new Button();
                buttonMenuBuy.Location = new Point(i * 170 + 85, 290);
                buttonMenuBuy.Width = 170;
                buttonMenuBuy.Height = 40;
                buttonMenuBuy.Click += ButtonMenuBuy_Click;
                Controls.Add(buttonMenuBuy);

                Label labelMenuPrice = new Label();
                labelMenuPrice.Location = new Point(i * 170 +140, 335);
                labelMenuPrice.AutoSize = true;
                Controls.Add(labelMenuPrice);

                //컨트롤들에 값넣기
                buttonMenuBuy.Text = row["name"].ToString();
                labelMenuPrice.Text = row["price"].ToString() + "원";

                if(row["image"] != System.DBNull.Value) {
                    byte[] menuImage = (byte[])row["image"];
                    if (menuImage != null)
                    {
                        pictureBoxMenuImage.Image = new Bitmap(new MemoryStream(menuImage));
                        pictureBoxMenuImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                i++;
            }
        }

        private void ButtonMenuBuy_Click(object sender, EventArgs e)
        {
            string buttonClickName = ((Button)sender).Text;
            //여기서 얻은 이름으로 menu 테이블에서 ID를 검색해서 sale테이블에 데이터 삽입 ==> 쿼리 한번으로 될 것 같기도 하고..? WHERE안에 select넣으면 되지 않나
            //음... ID 하나만 넣을 수는 없는 것 같아
            DataTable dataTable = DBManager.GetInstance().select("SELECT ID FROM DBP_QUIZ_menu WHERE name = '" + buttonClickName + "'");
            DataRow dtRow = dataTable.Rows[0];
            int menuID = Convert.ToInt32(dtRow["ID"]);

            string query = "INSERT INTO DBP_QUIZ_sale VALUES(NULL, " + menuID + ", '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "')";
            DBManager.GetInstance().insert(query);
        }

        private void userLogCheck_Click(object sender, EventArgs e)
        {
            UserLogViewForm userLogViewForm = new UserLogViewForm();
            userLogViewForm.Show();
        }
    }
}
