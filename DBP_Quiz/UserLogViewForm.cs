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
    public partial class UserLogViewForm : Form
    {
        public UserLogViewForm()
        {
            InitializeComponent();
            loadUserLog();
        }

        private void loadUserLog()
        {
            DataTable dt = DBManager.GetInstance().select("SELECT * FROM DBP_QUIZ_userLog");
            dataGridView1.DataSource = dt;
        }
    }
}
