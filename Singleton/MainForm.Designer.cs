
namespace Singleton
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadStudentInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxConfigManager = new System.Windows.Forms.GroupBox();
            this.checkBoxStartRecentUseMajorInfoPrint = new System.Windows.Forms.CheckBox();
            this.checkBoxStartAutoLoadStudentInfo = new System.Windows.Forms.CheckBox();
            this.listBoxMajorList = new System.Windows.Forms.ListBox();
            this.textBoxNewMajorInput = new System.Windows.Forms.TextBox();
            this.buttonMajorAdd = new System.Windows.Forms.Button();
            this.groupBoxStudent1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent1Sid = new System.Windows.Forms.TextBox();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.labelStudnet1Gender = new System.Windows.Forms.Label();
            this.labelStudent1Sid = new System.Windows.Forms.Label();
            this.labelStudent1Name = new System.Windows.Forms.Label();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.buttonStudent1Delete = new System.Windows.Forms.Button();
            this.buttonStudent2Delete = new System.Windows.Forms.Button();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.groupBoxStudent2 = new System.Windows.Forms.GroupBox();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent2Sid = new System.Windows.Forms.TextBox();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStudent3Delete = new System.Windows.Forms.Button();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.groupBoxStudent3 = new System.Windows.Forms.GroupBox();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent3Sid = new System.Windows.Forms.TextBox();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxConfigManager.SuspendLayout();
            this.groupBoxStudent1.SuspendLayout();
            this.groupBoxStudent2.SuspendLayout();
            this.groupBoxStudent3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(30, 38);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(248, 39);
            this.buttonLoadStudentInfo.TabIndex = 0;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "전공리스트";
            // 
            // groupBoxConfigManager
            // 
            this.groupBoxConfigManager.Controls.Add(this.checkBoxStartRecentUseMajorInfoPrint);
            this.groupBoxConfigManager.Controls.Add(this.checkBoxStartAutoLoadStudentInfo);
            this.groupBoxConfigManager.Location = new System.Drawing.Point(314, 27);
            this.groupBoxConfigManager.Name = "groupBoxConfigManager";
            this.groupBoxConfigManager.Size = new System.Drawing.Size(705, 50);
            this.groupBoxConfigManager.TabIndex = 2;
            this.groupBoxConfigManager.TabStop = false;
            this.groupBoxConfigManager.Text = "설정";
            // 
            // checkBoxStartRecentUseMajorInfoPrint
            // 
            this.checkBoxStartRecentUseMajorInfoPrint.AutoSize = true;
            this.checkBoxStartRecentUseMajorInfoPrint.Location = new System.Drawing.Point(355, 22);
            this.checkBoxStartRecentUseMajorInfoPrint.Name = "checkBoxStartRecentUseMajorInfoPrint";
            this.checkBoxStartRecentUseMajorInfoPrint.Size = new System.Drawing.Size(344, 19);
            this.checkBoxStartRecentUseMajorInfoPrint.TabIndex = 1;
            this.checkBoxStartRecentUseMajorInfoPrint.Text = "프로그램 시작시 최근 사용 전공 정보부터 출력";
            this.checkBoxStartRecentUseMajorInfoPrint.UseVisualStyleBackColor = true;
            this.checkBoxStartRecentUseMajorInfoPrint.CheckedChanged += new System.EventHandler(this.checkBoxStartRecentUseMajorInfoPrint_CheckedChanged);
            // 
            // checkBoxStartAutoLoadStudentInfo
            // 
            this.checkBoxStartAutoLoadStudentInfo.AutoSize = true;
            this.checkBoxStartAutoLoadStudentInfo.Location = new System.Drawing.Point(25, 22);
            this.checkBoxStartAutoLoadStudentInfo.Name = "checkBoxStartAutoLoadStudentInfo";
            this.checkBoxStartAutoLoadStudentInfo.Size = new System.Drawing.Size(304, 19);
            this.checkBoxStartAutoLoadStudentInfo.TabIndex = 0;
            this.checkBoxStartAutoLoadStudentInfo.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxStartAutoLoadStudentInfo.UseVisualStyleBackColor = true;
            this.checkBoxStartAutoLoadStudentInfo.CheckedChanged += new System.EventHandler(this.checkBoxStartAutoLoadStudentInfo_CheckedChanged);
            // 
            // listBoxMajorList
            // 
            this.listBoxMajorList.FormattingEnabled = true;
            this.listBoxMajorList.ItemHeight = 15;
            this.listBoxMajorList.Location = new System.Drawing.Point(34, 136);
            this.listBoxMajorList.Name = "listBoxMajorList";
            this.listBoxMajorList.Size = new System.Drawing.Size(173, 124);
            this.listBoxMajorList.TabIndex = 3;
            this.listBoxMajorList.SelectedIndexChanged += new System.EventHandler(this.listBoxMajorList_SelectedIndexChanged);
            // 
            // textBoxNewMajorInput
            // 
            this.textBoxNewMajorInput.Location = new System.Drawing.Point(34, 266);
            this.textBoxNewMajorInput.Name = "textBoxNewMajorInput";
            this.textBoxNewMajorInput.Size = new System.Drawing.Size(173, 25);
            this.textBoxNewMajorInput.TabIndex = 4;
            this.textBoxNewMajorInput.Text = "신규전공입력하세요";
            // 
            // buttonMajorAdd
            // 
            this.buttonMajorAdd.Location = new System.Drawing.Point(34, 298);
            this.buttonMajorAdd.Name = "buttonMajorAdd";
            this.buttonMajorAdd.Size = new System.Drawing.Size(173, 23);
            this.buttonMajorAdd.TabIndex = 5;
            this.buttonMajorAdd.Text = "전공추가";
            this.buttonMajorAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudent1
            // 
            this.groupBoxStudent1.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1Sid);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1Name);
            this.groupBoxStudent1.Controls.Add(this.labelStudnet1Gender);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Sid);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Name);
            this.groupBoxStudent1.Location = new System.Drawing.Point(232, 109);
            this.groupBoxStudent1.Name = "groupBoxStudent1";
            this.groupBoxStudent1.Size = new System.Drawing.Size(225, 151);
            this.groupBoxStudent1.TabIndex = 6;
            this.groupBoxStudent1.TabStop = false;
            this.groupBoxStudent1.Text = "학생1";
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(68, 109);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent1Gender.TabIndex = 5;
            // 
            // textBoxStudent1Sid
            // 
            this.textBoxStudent1Sid.Location = new System.Drawing.Point(68, 67);
            this.textBoxStudent1Sid.Name = "textBoxStudent1Sid";
            this.textBoxStudent1Sid.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent1Sid.TabIndex = 4;
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(68, 27);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent1Name.TabIndex = 3;
            // 
            // labelStudnet1Gender
            // 
            this.labelStudnet1Gender.AutoSize = true;
            this.labelStudnet1Gender.Location = new System.Drawing.Point(21, 112);
            this.labelStudnet1Gender.Name = "labelStudnet1Gender";
            this.labelStudnet1Gender.Size = new System.Drawing.Size(37, 15);
            this.labelStudnet1Gender.TabIndex = 2;
            this.labelStudnet1Gender.Text = "성별";
            // 
            // labelStudent1Sid
            // 
            this.labelStudent1Sid.AutoSize = true;
            this.labelStudent1Sid.Location = new System.Drawing.Point(21, 70);
            this.labelStudent1Sid.Name = "labelStudent1Sid";
            this.labelStudent1Sid.Size = new System.Drawing.Size(37, 15);
            this.labelStudent1Sid.TabIndex = 1;
            this.labelStudent1Sid.Text = "학번";
            // 
            // labelStudent1Name
            // 
            this.labelStudent1Name.AutoSize = true;
            this.labelStudent1Name.Location = new System.Drawing.Point(21, 30);
            this.labelStudent1Name.Name = "labelStudent1Name";
            this.labelStudent1Name.Size = new System.Drawing.Size(37, 15);
            this.labelStudent1Name.TabIndex = 0;
            this.labelStudent1Name.Text = "이름";
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(253, 283);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent1Save.TabIndex = 7;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            // 
            // buttonStudent1Delete
            // 
            this.buttonStudent1Delete.Location = new System.Drawing.Point(350, 283);
            this.buttonStudent1Delete.Name = "buttonStudent1Delete";
            this.buttonStudent1Delete.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent1Delete.TabIndex = 8;
            this.buttonStudent1Delete.Text = "삭제";
            this.buttonStudent1Delete.UseVisualStyleBackColor = true;
            // 
            // buttonStudent2Delete
            // 
            this.buttonStudent2Delete.Location = new System.Drawing.Point(613, 283);
            this.buttonStudent2Delete.Name = "buttonStudent2Delete";
            this.buttonStudent2Delete.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent2Delete.TabIndex = 11;
            this.buttonStudent2Delete.Text = "삭제";
            this.buttonStudent2Delete.UseVisualStyleBackColor = true;
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(516, 283);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent2Save.TabIndex = 10;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudent2
            // 
            this.groupBoxStudent2.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBoxStudent2.Controls.Add(this.textBoxStudent2Sid);
            this.groupBoxStudent2.Controls.Add(this.textBoxStudent2Name);
            this.groupBoxStudent2.Controls.Add(this.label2);
            this.groupBoxStudent2.Controls.Add(this.label3);
            this.groupBoxStudent2.Controls.Add(this.label4);
            this.groupBoxStudent2.Location = new System.Drawing.Point(495, 109);
            this.groupBoxStudent2.Name = "groupBoxStudent2";
            this.groupBoxStudent2.Size = new System.Drawing.Size(225, 151);
            this.groupBoxStudent2.TabIndex = 9;
            this.groupBoxStudent2.TabStop = false;
            this.groupBoxStudent2.Text = "학생2";
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(68, 109);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent2Gender.TabIndex = 5;
            // 
            // textBoxStudent2Sid
            // 
            this.textBoxStudent2Sid.Location = new System.Drawing.Point(68, 67);
            this.textBoxStudent2Sid.Name = "textBoxStudent2Sid";
            this.textBoxStudent2Sid.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent2Sid.TabIndex = 4;
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(68, 27);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent2Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "성별";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름";
            // 
            // buttonStudent3Delete
            // 
            this.buttonStudent3Delete.Location = new System.Drawing.Point(879, 283);
            this.buttonStudent3Delete.Name = "buttonStudent3Delete";
            this.buttonStudent3Delete.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent3Delete.TabIndex = 11;
            this.buttonStudent3Delete.Text = "삭제";
            this.buttonStudent3Delete.UseVisualStyleBackColor = true;
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(782, 283);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(90, 23);
            this.buttonStudent3Save.TabIndex = 10;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudent3
            // 
            this.groupBoxStudent3.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBoxStudent3.Controls.Add(this.textBoxStudent3Sid);
            this.groupBoxStudent3.Controls.Add(this.textBoxStudent3Name);
            this.groupBoxStudent3.Controls.Add(this.label5);
            this.groupBoxStudent3.Controls.Add(this.label6);
            this.groupBoxStudent3.Controls.Add(this.label7);
            this.groupBoxStudent3.Location = new System.Drawing.Point(761, 109);
            this.groupBoxStudent3.Name = "groupBoxStudent3";
            this.groupBoxStudent3.Size = new System.Drawing.Size(225, 151);
            this.groupBoxStudent3.TabIndex = 9;
            this.groupBoxStudent3.TabStop = false;
            this.groupBoxStudent3.Text = "학생3";
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(68, 109);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent3Gender.TabIndex = 5;
            // 
            // textBoxStudent3Sid
            // 
            this.textBoxStudent3Sid.Location = new System.Drawing.Point(68, 67);
            this.textBoxStudent3Sid.Name = "textBoxStudent3Sid";
            this.textBoxStudent3Sid.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent3Sid.TabIndex = 4;
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(68, 27);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent3Name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "학번";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "이름";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 356);
            this.Controls.Add(this.buttonStudent3Delete);
            this.Controls.Add(this.buttonStudent2Delete);
            this.Controls.Add(this.buttonStudent3Save);
            this.Controls.Add(this.buttonStudent2Save);
            this.Controls.Add(this.groupBoxStudent3);
            this.Controls.Add(this.groupBoxStudent2);
            this.Controls.Add(this.buttonStudent1Delete);
            this.Controls.Add(this.buttonStudent1Save);
            this.Controls.Add(this.groupBoxStudent1);
            this.Controls.Add(this.buttonMajorAdd);
            this.Controls.Add(this.textBoxNewMajorInput);
            this.Controls.Add(this.listBoxMajorList);
            this.Controls.Add(this.groupBoxConfigManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Name = "MainForm";
            this.Text = "데이터베이스프로그래밍 실습3";
            this.groupBoxConfigManager.ResumeLayout(false);
            this.groupBoxConfigManager.PerformLayout();
            this.groupBoxStudent1.ResumeLayout(false);
            this.groupBoxStudent1.PerformLayout();
            this.groupBoxStudent2.ResumeLayout(false);
            this.groupBoxStudent2.PerformLayout();
            this.groupBoxStudent3.ResumeLayout(false);
            this.groupBoxStudent3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxConfigManager;
        private System.Windows.Forms.CheckBox checkBoxStartAutoLoadStudentInfo;
        private System.Windows.Forms.CheckBox checkBoxStartRecentUseMajorInfoPrint;
        private System.Windows.Forms.ListBox listBoxMajorList;
        private System.Windows.Forms.TextBox textBoxNewMajorInput;
        private System.Windows.Forms.Button buttonMajorAdd;
        private System.Windows.Forms.GroupBox groupBoxStudent1;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.TextBox textBoxStudent1Sid;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Label labelStudnet1Gender;
        private System.Windows.Forms.Label labelStudent1Sid;
        private System.Windows.Forms.Label labelStudent1Name;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.Button buttonStudent1Delete;
        private System.Windows.Forms.Button buttonStudent2Delete;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.GroupBox groupBoxStudent2;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.TextBox textBoxStudent2Sid;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStudent3Delete;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.GroupBox groupBoxStudent3;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.TextBox textBoxStudent3Sid;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

