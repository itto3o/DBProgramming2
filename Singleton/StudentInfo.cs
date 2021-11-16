using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    class StudentInfo
    {
        //private TextBox name = new TextBox();
        //private TextBox sid = new TextBox();
        //private ComboBox gender = new ComboBox();

        public void AddOrUpdate(string name, string sid, string gender, string major)
        {
            //입력받은 내용으로 DB에 저장
            //name, sid, gender, major 정보를 저장 sid를 기준으로 기존에 있던 값이면 update할 수 있게
            string str = "(NULL, '" + name + "', '" + sid + "', '" + gender + "', '"+ major + "')";
            string query = "insert into DBP_studentInfo values" + str + "ON DUPLICATE KEY UPDATE name = values(name), sid = values(sid), gender = values(gender), major = values(major)";

            DBManager.GetInstance().insert(query);
        }

        //sid가 UQ라 sid를 기준으로 테이블 삭제
        public void Delete(string sid)
        {
            string query = "DELETE FROM DBP_studentInfo WHERE sid = '" + sid + "'";
            DBManager.GetInstance().delete(query);
        }
    }
}
