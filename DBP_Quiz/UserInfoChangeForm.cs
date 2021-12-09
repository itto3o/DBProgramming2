using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_Quiz
{
    public partial class UserInfoChangeForm : Form
    {
        private string userID_ = "";

        public UserInfoChangeForm(string userID)
        {
            InitializeComponent();
            this.userID_ = userID;
            labelUserID.Text = userID;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //한글자 이상씩의 대문자, 숫자, 특수문자 포함 / 8자 이상
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[\W]).{8,}$");
            string pw = textBoxUserPWInput.Text;
            if (regex.IsMatch(pw))
            {
                DBManager.GetInstance().update("UPDATE DBP_QUIZ_user SET userPW = hex(aes_encrypt('" + pw + "', 'pw')) WHERE userID = '" + userID_ + "'");
                MessageBox.Show("저장되었습니다.");
                this.Close();
            }

            else
                MessageBox.Show("비밀번호 규칙에 맞게 입력해주세요.");
        }
    }
}
