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
    public partial class LoginForm : Form
    {
        private string userID = "";
        private int adminCheck = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //암호화는 insert into s5584534.DBP_QUIZ_user values(null, 'admin', hex(aes_encrypt('admin','pw')), 1); 이런식으로
            //복호화해서 검색
            string query = "SELECT userID, CAST(AES_DECRYPT(unhex(userPW), 'pw') as char) as userPW, adminCheck FROM DBP_QUIZ_user";
            DataTable dt = DBManager.GetInstance().select(query);
            foreach(DataRow row in dt.Rows)
            {
                string userID = row["userID"].ToString();
                string userPW = row["userPW"].ToString();
                int admin = Convert.ToInt32(row["adminCheck"]);

                if (textBoxIDInput.Text == userID && textBoxPWInput.Text == userPW)
                {
                    if (admin == 1)
                        adminCheck = 1;
                    userID = textBoxIDInput.Text;

                    this.Hide();
                    //로그 기록
                    MainForm mainForm = new MainForm(userID, adminCheck);
                    mainForm.ShowDialog();
                    this.Close();
                }
             }
            MessageBox.Show("로그인 실패");
            textBoxIDInput.Text = "";
            textBoxPWInput.Text = "";
        }
    }
}
