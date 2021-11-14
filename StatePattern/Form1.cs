using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            int eatStateFlag = 0;
            int sleepStateFlag = 0;
            int showerStateFlag = 0;

            string currentState = "기상";
            string ifstate = "";

            while(true)
            {
                switch (ifstate)
                {
                    case "배가 고프다":
                        currentState = "밥";
                        eatStateFlag = 1;
                        break;

                    case "씻고 싶다":
                        //밥을 먹은 후에 샤워 가능
                        if (eatStateFlag == 1)
                        {
                            currentState = "샤워";
                            showerStateFlag = 1;
                        }
                        break;

                    case "학교 간다":
                        //밥을 먹고 샤워를 한 후에 학교를 갈 수 있음
                        //showerStateFlag만 확인해도 됨
                        if(eatStateFlag == 1 && showerStateFlag == 1)
                        {
                            currentState = "학교";
                        }
                        break;

                    case "자고 싶다":
                        currentState = "잠";
                        sleepStateFlag = 1;
                        break;

                    //다시 초기 상태
                    case "잠에서 깼다":
                        if (sleepStateFlag == 1)
                        {
                            sleepStateFlag = 0;
                            eatStateFlag = 0;
                            showerStateFlag = 0;
                            currentState = "기상";
                        }
                        break;
                }
            }

        }
        public partial enum MYSTATE
        {
            MAKEUP,
            SHOWER,
            SLEEPING,
            BREAKFAST,
            SCHOOL
        }

        public void InitVariables()
        {
            state = MYSTATE state;
        }
        //교수님의 해답
        public void DoWork()
        {
           while(true)
            {
                switch(state)
                {
                    case MYSTATE MAKEUP:
                        Do_Wakeup();
                        if(isSleeping()) {  state=MYSTATE SLEEPING; //==>다른 case문 자동 실행 }
                        else if(isHungry()) {  state=MYSTATE BREAKFAST; }
                        break;

                    case MYSTATE BREAFAST:
                        Do_Breakfast();
                        break;


                    case MYSTATE SHOWER:
                        Do_Shower();
                        break;


                    case MYSTATE SLEEPING:
                        Do_Sleeping();
                        break;


                    case MYSTATE SCHOOL:
                        Do_School();
                        break;
                }
                //전공리스트 추가한 버전 학생class 전공class(별도로 만들어 둬야 확장을 할 수 있대) 설정class(기능은 다 class로 빼래)
            }
        }
    }
}
