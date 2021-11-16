using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    //MainForm의 major listBox를 protected로 선언해서 MainForm을 상속받아 MainForm의 listBox를 사용할 수 있음
    //상속으로 하려고 했는데 MainForm에서 MajorInfo 객체가 생성되는 곳이 있어 부모인 MainForm 생성자가 자꾸 호출되어 stackoverflow가 일어난다.
    class MajorInfo
    {
        //private ListBox listBox = new ListBox();
        public void Add()
        {
            //MainForm에서 public static으로 만든 mainForm으로 접근해서 MainForm의 control들에 접근한다.
            //이때 접근할 control들은 mainform에서 modifiers 속성 값을 public으로 바꿔야 한다.

            //mainform의 list에 textBox의 값(새로운 전공)을 추가한다.
            MainForm.mainForm.listBoxMajorList.Items.Add(MainForm.mainForm.textBoxNewMajorInput.Text);
            //DB의 majorInfo table에 추가한다.
            DBManager.GetInstance().insert("INSERT INTO DBP_majorInfo VALUES (NULL, '" + MainForm.mainForm.textBoxNewMajorInput.Text + "')");

            //추가가 된 후에는 비우기
            MainForm.mainForm.textBoxNewMajorInput.Text = "";
        }
    }
}
