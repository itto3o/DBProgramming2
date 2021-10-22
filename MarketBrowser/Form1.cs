using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MarketBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<List<string>> MakeColumnnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();
            var headers = line.Split(',');

            //큰 범위의 list는 헤더를 담은 리스트를 담음
            List<List<string>> data = new List<List<string>>();
            //헤더 개수만큼 리스트 필요
            foreach (string header in headers)
            {
                List<string> list = new List<string>();
                list.Add(header); //리스트에 헤더가 하나씩 들어감

                data.Add(list); 
            }

            int row = 0;
            while(sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');
                //|우리시장 | 5일장 | 대구시 | ... //row라면 그냥 넣어도 됨

                //foreach는 next포인터를 쫓아가기때문에 좀 더 빠르고, for는 i++하고 i++한 곳으로 indexing하기 때문에
                //values는 길이가 13인데 data는 12개까지밖에 안됨
                //위에서 headers는 0~11인데 위의 values는 0~12임: 임계시장(구, 송계시장)이 ,으로 분리되었기 때문
                for(int i = 0; i < values.Length; i++)
                {
                    //data의 i 번째라는 것은 column별로 시장명엔 우리시장, 종류엔 5일장, 장소엔 대구시 이렇게 들어감
                    data[i].Add(values[i]);
                }
               
                if (row++ == 10)
                    break;
            }

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int ColumnIdx)
        {
            string str = "";
            textBoxCSVViewer.Text = "";
            //두번째 컬럼에 있는 내용들 출력시키기
            foreach (string value in data[ColumnIdx])
            {
                str += value + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void printRowData_columnbased(List<List<string>> data)
        {
            string str = "";
            textBoxCSVViewer.Text = "";

            //헤더의 개수만큼
            for (int row = 0; row < data[0].Count; row++)
            {
                foreach(List<string> list in data)
                {
                   //list에는 컬럼별로 저장되어있음
                   //list에 값이 제대로 들어가있지 않음. 개설년도 field는 위에서 10개까지만 받기 때문에 걸린듯
                   //==> 그래서 위에서 Add할때 row++ == 10으로 고침
                   //-->그러면 모든 데이터를 10개씩 받아오는 걸까
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;

            /*내가 짠코드
            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data[j].Count; j++)
                {
                    str += data[j][i];
                }
            }
            textBoxCSVViewer.Text = str;
            */
        }
        private string[] parseCSVLine(string line)
        {

            /*
            //1. 문자열을 일단 나눠서 ""빼고 합치기..
            //2. "나올때까지 split하다가 "나오면 "가 다시나올때까지 뛰어넘고 다시 split
            //3. "" 안의 것들만 const로 만들 수 있나..?, const로 만들어도 나누기 가능하지 않나
            //4. ""안의 컴마를 공백으로 바꾼 다음에 split하고 다시 출력할 때 ""이랑 안의 공백을 ,으로 바꿔서 내보내기! <<오 이렇게할까 해보니까 ""split하면 없어짐ㅋㅋ
            //5. 4.하려면 ""으로 분리한 다음에 그 단어의 ,을 공백으로 바꿔야겠는데..?    if (line[i] == ',') line[i] = ' '; 으로 하니까 읽기전용이라고 안된다

            //엥 return을 이렇게 하면 결국 나눠지지 않나
            return line.Split(',');
            */


            //string의 값을 변경하기 위해 char[]형으로 바꾸어준다.
            //indexing으로 할당하면 읽기전용이라고 뜸
            char[] lineCopy = line.ToCharArray();

            if (line.Contains('"'))
            {
                int startQuoter = line.IndexOf('"');
               
                for(int i = startQuoter; i < line.Length; i++)
                {
                    //만약 " 후에 ,가 나오면 그 위치를 저장하고 그것을 #으로 바꾼 후에 break;
                    if (lineCopy[i] == ',')
                    {
                        lineCopy[i] = '#';
                        break;
                    }
                }
            }
            //tocharArray했던 것을 다시 string으로
            string str = string.Join("", lineCopy);
            return str.Split(',');
        }

        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>();
        private void SetHeaderList(string header)
        {
            var values = parseCSVLine(header);
            //foreach(string value in values)
            //    listBoxHeaders.Items.Add(value);

            listBoxHeaders.Items.Clear();

            for(int i = 0; i < values.Length; i++)
            {
                string column = values[i];
                listBoxHeaders.Items.Add(column);
                //순차 검색을 하지 않도록
                headerIndexDict[column] = i;
            }
            //컬렉션을 넣어주면 데이터가 그대로 들어감
            //listBoxHeaders.Items.AddRange(values);
        }

        private List<List<string>> MakeRowBasedDataStructure(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();
            SetHeaderList(line);

            //큰 범위의 list는 헤더를 담은 리스트를 담음
            List<List<string>> data = new List<List<string>>();

            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                //"시장(구, 우리시장)"을 해결하기 hint : 데이터struct를 그대로 코드로 "으로 시작한게 있으면 "으로 끝나는 것을 새롭게 하나의 string으로
                var values = parseCSVLine(line);
                
                //split해서 나온 결과에는 아직 ""이랑 ,가 #으로 바뀐 게 있으니까
                //(split하기 전, 즉 parseCSVLine() 함수를 return하기 전에는 할 수 없음)
                for(int i = 0; i < values.Length; i++)
                {
                    if (values[i].Contains("\"")) {
                        //'"', ''는 char로 바꾸는 거라서 char에는 공백이 들어가면 안되므로 오류뜸, string인 ""으로 해줘야함
                        //Replace는 string을 직접 바꾸는 게 아니고 return이 되어서 나오기 때문에 다시 할당해줘야함 --> foreach로는 못함(이터레이터에 할당x)
                        values[i] = values[i].Replace("#", ", ");
                        values[i] = values[i].Replace("\"", "");
                        break;
                    }
                }

                //|우리시장 | 5일장 | 대구시 | ... //row라면 그냥 넣어도 됨

                //Tolist로 하면 list형태로 들어감
                data.Add(values.ToList());

                //if (row++ == 10)
                  //  break;
            }

            sr.Close();
            return data;
        }
        private void printRowData_rowbased (List<List<string>> data, TextBox textBox)
        {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                    str += value + "\t";
                str += "\r\n";
            }
            //파라미터로 온 textBox에 출력이 되도록(textbox지정)
            textBox.Text = str;
        }

        private void printColumnData_rowbased(List<List<string>> data, int colIdx)
        {
            string str = "";
            //column을 돌면서 위치를 읽어오기
            foreach(List<string> rowlist in data)
            {
                //list를 돌면서 colIdx에 접근
                str += rowlist[colIdx] + "\r\n";

                //내가 짠 코드
                //for(int column = 0; column < data[colIdx].Count; column++)
                //{
                //   str += list[colIdx];
                //}
            }
            textBoxCSVViewer.Text = str;
        }

        List<List<string>> data;

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if(dResult == DialogResult.OK)
            {
                string filename = FD.FileName;

                data = MakeRowBasedDataStructure(filename);
                //textbox도 넣어줘서 출력 대상 위치를 지정해줄수 있게
                printRowData_rowbased(data, textBoxCSVViewer);
            }

            /*

            //printColumnData_rowbased(data, 1);

            /*컬럼 기반
            List<List<string>> data = MakeColumnnarDataStructure();
            //printColumnData_columnbased(data, 1);
            printRowData_columnbased(data);
            */
            
        }

        private object OpenFileDialog()
        {
            throw new NotImplementedException();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;

            if(keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요.", "확인");
                return;
            }
            if (listBoxHeaders.SelectedItem == null)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }
            string column = listBoxHeaders.SelectedItem.ToString();
            if(column == "")
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            MessageBox.Show("키워드 = " + keyword + "  컬럼 = " + column, "확인");

            DoSearch(keyword, column);

        }
        private void DoSearch(string keyword, string column)
        {
            //row기준이니까 list<string>이 하나의 row를 의미함
            //1. 대상 컬럼 확인
            //몇번째 컬럼을 선택했는가
            //int targetColumnIndex = listBoxHeaders.SelectedIndex;

            int targetColumnIndex = -1;
            //column에 대한 값이 없다면 검색을 할 수 없으니까 에러처리
            //dict을 쓸때 항상 체크할것
            if(!(headerIndexDict.ContainsKey(column)))
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }
            //logn의 시간을 갖는 딕셔너리 활용
            targetColumnIndex = headerIndexDict[column];

            // 2. 대상 컬럼에서 키워드를 포함하는지 확인
            //결과를 담는 structure
            List<List<string>> resultData = new List<List<string>>();
            foreach(List<string> row in data)
            {
                //검색 대상의 값
                string value = row[targetColumnIndex];
                if(value.Contains(keyword))
                {
                    resultData.Add(row);
                }
            }
            //search textbox에 출력
            printRowData_rowbased(resultData, textBoxSearchResult);
        }
        string strconn = "Server=27.96.130.41;Database=s5584534;Uid=s5584534;Pwd=s5584534;Charset=utf8";
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            /*using (MySqlConncetion conn = new MySqlConncetion(strconn))
            {
                conn.Open();

                
                /*string query = "INSERT INTO student(name, gender) values ('박길동', '남자')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //결과값이 없을때 사용
                cmd.ExecuteNonQuery();
                

                string query = "select * from student";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //row단위로
                while(rdr.Read())
                {
                    string str = rdr["id"] + " " + rdr["name"] + " " + rdr["gender"];
                    MessageBox.Show(str);
                }
                rdr.Close();
            }*/
        }
    }
}
