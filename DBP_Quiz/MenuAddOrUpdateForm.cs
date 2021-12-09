using MySql.Data.MySqlClient;
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
    public partial class MenuAddOrUpdateForm : Form
    {
        private string userID_ = "";
        public MenuAddOrUpdateForm(string userID)
        {
            InitializeComponent();
            this.userID_ = userID;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }

            else
                return;

            pictureBoxMenuImage.Image = Bitmap.FromFile(image_file);
            pictureBoxMenuImage.Tag = dialog.FileName;
            pictureBoxMenuImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonSaveMenu_Click(object sender, EventArgs e)
        {
            //저번에 했던 DB과제 참고
            //string str3 = "(3, '" + textBoxStudent3Name.Text + "', '" + textBoxStudent3ID.Text + "', '" + comboBoxStudent3Gender.Text + "', '" + textBoxStudent3Memo.Text + "')";
            //string query3 = "insert into student values" + str3 + "ON DUPLICATE KEY UPDATE name = values(name), sid = values(sid), gender = values(gender), memo = values(memo)";
            FileStream fs = new FileStream(pictureBoxMenuImage.Tag.ToString(), FileMode.Open, FileAccess.Read);
            byte[] bImage = new byte[fs.Length];
            fs.Read(bImage, 0, (int)fs.Length);

            //image 파라미터가 있어서 기존의 DBManager는 쓰지 않았다.
            using(MySqlConnection conn = new MySqlConnection("Server={SERVERIP};Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8"))
            {
                conn.Open();
                string addOrUpdate = "INSERT INTO DBP_QUIZ_menu VALUES(NULL, '" + textBoxMenuName.Text + "', " + textBoxMenuPrice.Text + ", @image) ON DUPLICATE KEY UPDATE name = values(name), price = values(price), image = values(image)";
                MySqlCommand cmd = new MySqlCommand(addOrUpdate, conn);
                cmd.Parameters.AddWithValue("@image", bImage);

                cmd.ExecuteNonQuery();
            }
            fs.Close();

            //지금 저장하는게 메뉴테이블의 몇번인지 모른다..!
            DataTable dataTableMenu = DBManager.GetInstance().select("SELECT ID FROM DBP_QUIZ_menu WHERE name = '" + textBoxMenuName.Text + "'");
            DataRow dataRowMenu = dataTableMenu.Rows[0];

            DBManager.GetInstance().insert("INSERT INTO DBP_QUIZ_menuChange VALUES(NULL, '" + userID_ + "', " + Convert.ToInt32(dataRowMenu["ID"]) + ", " + textBoxMenuPrice.Text + ", now())");

            MessageBox.Show("저장 완료");
            this.Close();
        }

        private void MenuAddOrUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
