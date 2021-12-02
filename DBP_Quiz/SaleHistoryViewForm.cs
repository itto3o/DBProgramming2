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
    public partial class SaleHistoryViewForm : Form
    {
        string userID = "";
        public SaleHistoryViewForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            ViewSaleHistory();
        }

        private void ViewSaleHistory()
        {
            DataTable dataTableSale = DBManager.GetInstance().select("SELECT s.date, s.tableID as 테이블번호, m.name as 메뉴이름, m.price, s.quantity, s.note as 비고, SUM(s.quantity * m.price) as 금액 FROM DBP_QUIZ_sale as s JOIN DBP_QUIZ_menu as m ON s.menuID = m.ID WHERE s.representativeUserID = '" + userID + "' GROUP BY s.date, s.tableID, m.name, m.price, s.quantity, s.note");
            dataGridViewSaleHistory.DataSource = dataTableSale;
        }
    }
}
