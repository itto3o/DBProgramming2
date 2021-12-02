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
        private int totalPrice = 0;
        private int admin = 0;
        private int tableNumber = 0;
        private string userID = "";
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string userID, int adminCheck, int tableNumber)
        {
            InitializeComponent();
            this.userID = userID;
            this.admin = adminCheck;
            this.tableNumber = tableNumber;
            welcome();
        }

        public int returnTotalPrice()
        {
            return totalPrice;
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
            //logout시 테이블 비우기
            DBManager.GetInstance().delete("DELETE FROM DBP_QUIZ_table WHERE ID = " + tableNumber);
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
            menuStripCasher.Visible = false;
            labelCasherView.Visible = false;
            labelTotalPrice.Visible = false;

            //생각을 해봤는데 메뉴를 동적으로 생성해야하지 않을까 메뉴 수정, 추가가 되니까 아 고칠거 많네...
            //와! 3조인!
            //select t.userID, date, SUM(quantity), SUM(price*quantity)
            //from DBP_QUIZ_sale as s
            //JOIN DBP_QUIZ_menu as m 
            //ON s.menuID = m.ID
            //JOIN DBP_QUIZ_table as t
            //ON s.tableID = t.ID
            //GROUP BY t.userID, date
            DataTable dtUserDaily = DBManager.GetInstance().select("SELECT s.representativeUserID as user, s.date, s.note as 비고, SUM(s.quantity) as 판매량, SUM(m.price * s.quantity) as 판매액 FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID GROUP BY s.representativeUserID, s.date, s.note");
            dataGridViewUserDay.DataSource = dtUserDaily;

            //SELECT m.name, s.date, SUM(s.quantity) as 판매량, SUM(m.price * s.quantity) as 판매액
            //FROM DBP_QUIZ_sale as s
            //JOIN DBP_QUIZ_menu as m
            //ON s.menuID = m.ID
            //GROUP BY m.name, s.date
            DataTable dtMenuDaily = DBManager.GetInstance().select("SELECT m.name, s.date, s.note as 비고, SUM(s.quantity) as 판매량, SUM(m.price * s.quantity) as 판매액 FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID GROUP BY m.name, s.date, s.note");
            dataGridViewMenuDaily.DataSource = dtMenuDaily;

            DataTable dtMenuMonthly = DBManager.GetInstance().select("SELECT m.name, MONTH(s.date) as 월, s.note as 비고, SUM(s.quantity) as 판매량, SUM(m.price * s.quantity) as 판매액 FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID GROUP BY m.name, MONTH(s.date), s.note");
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
                pictureBoxMenuImage.Location = new Point(i * 180 + 85, 130);
                pictureBoxMenuImage.Width = 170;
                pictureBoxMenuImage.Height = 140;
                Controls.Add(pictureBoxMenuImage);

                Button buttonMenuBuy = new Button();
                buttonMenuBuy.Location = new Point(i * 180 + 85, 290);
                buttonMenuBuy.Width = 80;
                buttonMenuBuy.Height = 40;
                buttonMenuBuy.Click += ButtonMenuBuy_Click;
                Controls.Add(buttonMenuBuy);

                Button buttonCancel = new Button();
                buttonCancel.Location = new Point(i * 180 + 175, 290);
                buttonCancel.Size = new Size(80, 40);
                buttonCancel.Text = "취소하기";
                buttonCancel.Tag = i;
                Controls.Add(buttonCancel);
                buttonCancel.Click += ButtonCancel_Click;

                Label labelMenuPrice = new Label();
                labelMenuPrice.Location = new Point(i * 180 + 130, 335);
                labelMenuPrice.AutoSize = true;
                Controls.Add(labelMenuPrice);

                //수량도
                NumericUpDown numericUpDownMenuQuantity = new NumericUpDown();
                numericUpDownMenuQuantity.Location = new Point(i * 180 + 180, 335);
                numericUpDownMenuQuantity.Size = new Size(40, 25);
                numericUpDownMenuQuantity.Tag = i;
                Controls.Add(numericUpDownMenuQuantity);

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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //태그를 불러와서 메뉴이름을 알아내고 그것에 맞는 메뉴ID를 찾아내서 userID, 메뉴ID가 둘다 맞는 걸로 아; 수량취소도 해야겠네..
            //잠시만 그러면 앞에꺼에 취소를 다는게 아니라 취소로 새 로우를 추가해야되네 ( 수량이 다를 수 있으니까)

            //메뉴 ID는 버튼의 태그에 +1 한값
            int menuID = Convert.ToInt32(((Button)sender).Tag) + 1;
            DataTable dataTable = DBManager.GetInstance().select("SELECT price FROM DBP_QUIZ_menu WHERE ID = " + menuID);
            DataRow dtRow = dataTable.Rows[0];
            int menuPrice = Convert.ToInt32(dtRow["price"]);

            //1. sale에 비고란에 '취소'를 넣고 로우 입력
            //2. total에서 가격 * 수량 만큼 빼기
            //3. 모든 통계에서는 취소가격만큼 빠져야하는데(이걸 표시를 해야함) ==> groupby에 취소여부도 쓰면 괜찮으려나 (취소니까 -붙여서 출력)
            //-> 관리자용 view, 판매기록


            NumericUpDown numericUpDown = new NumericUpDown();
            //menuID -1 이 numericUpDown tag니까
            foreach (Control control in this.Controls)
            {
                if (control is NumericUpDown)
                {
                    if (Convert.ToInt32(((NumericUpDown)control).Tag) == menuID - 1)
                        numericUpDown = (NumericUpDown)control;
                }
            }

            //메뉴ID, 수량, 테이블ID, userID, date, note
            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_sale VALUES(NULL, " + menuID + ", " + Convert.ToInt32(numericUpDown.Value) + ", " + tableNumber + ", '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '취소')");
            totalPrice -= Convert.ToInt32(numericUpDown.Value) * menuPrice;
            labelTotalPrice.Text = "총 결제 금액 : " + totalPrice + "원";
        }


        private void ButtonMenuBuy_Click(object sender, EventArgs e)
        {
            string buttonClickName = ((Button)sender).Text;

            //여기서 얻은 이름으로 menu 테이블에서 ID를 검색해서 sale테이블에 데이터 삽입 ==> 쿼리 한번으로 될 것 같기도 하고..? WHERE안에 select넣으면 되지 않나
            //음... ID 하나만 넣을 수는 없는 것 같아
            DataTable dataTable = DBManager.GetInstance().select("SELECT ID, price FROM DBP_QUIZ_menu WHERE name = '" + buttonClickName + "'");
            DataRow dtRow = dataTable.Rows[0];
            int menuID = Convert.ToInt32(dtRow["ID"]);

            NumericUpDown numericUpDown = new NumericUpDown();
            //menuID -1 이 numericUpDown tag니까
            foreach(Control control in this.Controls)
            {
                if(control is NumericUpDown)
                {
                    if (Convert.ToInt32(((NumericUpDown)control).Tag) == menuID - 1)
                        numericUpDown = (NumericUpDown)control;
                }
            }

            int menuPrice = Convert.ToInt32(dtRow["price"]);

            string query = "INSERT INTO DBP_QUIZ_sale VALUES(NULL, " + menuID + ", " + Convert.ToInt32(numericUpDown.Value) + ", " + tableNumber + ", '" + userID + "', '" + dateTimePickerDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', NULL)";
            DBManager.GetInstance().insert(query);
            totalPrice += Convert.ToInt32(numericUpDown.Value) * menuPrice;
            labelTotalPrice.Text = "총 결제 금액 : " + totalPrice + "원";
        }

        private void userLogCheck_Click(object sender, EventArgs e)
        {
            UserLogViewForm userLogViewForm = new UserLogViewForm();
            userLogViewForm.Show();
        }

        private void 지난내역보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleHistoryViewForm saleHistoryViewForm = new SaleHistoryViewForm(userID);
            saleHistoryViewForm.Show();
        }
    }
}
