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
    public partial class TableStatementForm : Form
    {
        private string userID="";
        public TableStatementForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            ViewCurrentTableStatement();
        }

        private void ViewCurrentTableStatement()
        {
            //사용중인 테이블은 사용중표시
            DataTable dataTableTableStatement = DBManager.GetInstance().select("SELECT ID FROM DBP_QUIZ_table");
            foreach(DataRow dataRowTableStatement in dataTableTableStatement.Rows)
            {
                foreach(Control control in this.Controls)
                {
                    if(control is Button)
                    {
                        if (Convert.ToInt32(dataRowTableStatement["ID"]) == Convert.ToInt32(((Button)control).Tag))
                        {
                            ((Button)control).BackColor = System.Drawing.Color.Aqua;
                        }
                    }
                }
            }
        }

        private void buttonTable1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.Aqua;

            int buttonTag = Convert.ToInt32(((Button)sender).Tag);
            MainForm mainForm = new MainForm(userID, 0, buttonTag);

            mainForm.ShowDialog();

            MessageBox.Show("총 " + mainForm.returnTotalPrice() + "원 입니다.");
            this.Close();
        }
    }
}
