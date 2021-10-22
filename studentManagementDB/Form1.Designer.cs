
namespace studentManagementDB
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCurrentSaveStudent = new System.Windows.Forms.Label();
            this.checkBoxAutoLoad = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStudent1Delete = new System.Windows.Forms.Button();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent1Memo = new System.Windows.Forms.TextBox();
            this.textBoxStudent1ID = new System.Windows.Forms.TextBox();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStudent2Delete = new System.Windows.Forms.Button();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent2Memo = new System.Windows.Forms.TextBox();
            this.textBoxStudent2ID = new System.Windows.Forms.TextBox();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonStudent3Delete = new System.Windows.Forms.Button();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent3Memo = new System.Windows.Forms.TextBox();
            this.textBoxStudent3ID = new System.Windows.Forms.TextBox();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(27, 13);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(191, 93);
            this.buttonLoadStudentInfo.TabIndex = 0;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCurrentSaveStudent);
            this.groupBox1.Controls.Add(this.checkBoxAutoLoad);
            this.groupBox1.Location = new System.Drawing.Point(263, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정 및 정보";
            // 
            // labelCurrentSaveStudent
            // 
            this.labelCurrentSaveStudent.AutoSize = true;
            this.labelCurrentSaveStudent.Location = new System.Drawing.Point(25, 61);
            this.labelCurrentSaveStudent.Name = "labelCurrentSaveStudent";
            this.labelCurrentSaveStudent.Size = new System.Drawing.Size(155, 15);
            this.labelCurrentSaveStudent.TabIndex = 2;
            this.labelCurrentSaveStudent.Text = "현재 저장된 학생수: 0";
            // 
            // checkBoxAutoLoad
            // 
            this.checkBoxAutoLoad.AutoSize = true;
            this.checkBoxAutoLoad.Location = new System.Drawing.Point(28, 24);
            this.checkBoxAutoLoad.Name = "checkBoxAutoLoad";
            this.checkBoxAutoLoad.Size = new System.Drawing.Size(304, 19);
            this.checkBoxAutoLoad.TabIndex = 0;
            this.checkBoxAutoLoad.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxAutoLoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoLoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoLoad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStudent1Delete);
            this.groupBox2.Controls.Add(this.buttonStudent1Save);
            this.groupBox2.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBox2.Controls.Add(this.textBoxStudent1Memo);
            this.groupBox2.Controls.Add(this.textBoxStudent1ID);
            this.groupBox2.Controls.Add(this.textBoxStudent1Name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생1";
            // 
            // buttonStudent1Delete
            // 
            this.buttonStudent1Delete.Location = new System.Drawing.Point(70, 266);
            this.buttonStudent1Delete.Name = "buttonStudent1Delete";
            this.buttonStudent1Delete.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent1Delete.TabIndex = 12;
            this.buttonStudent1Delete.Text = "삭제";
            this.buttonStudent1Delete.UseVisualStyleBackColor = true;
            this.buttonStudent1Delete.Click += new System.EventHandler(this.buttonStudent1Delete_Click);
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(70, 237);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent1Save.TabIndex = 11;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(70, 93);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent1Gender.TabIndex = 10;
            this.comboBoxStudent1Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent1Gender_SelectedIndexChanged);
            // 
            // textBoxStudent1Memo
            // 
            this.textBoxStudent1Memo.Location = new System.Drawing.Point(70, 122);
            this.textBoxStudent1Memo.Multiline = true;
            this.textBoxStudent1Memo.Name = "textBoxStudent1Memo";
            this.textBoxStudent1Memo.Size = new System.Drawing.Size(121, 109);
            this.textBoxStudent1Memo.TabIndex = 9;
            this.textBoxStudent1Memo.TextChanged += new System.EventHandler(this.textBoxStudent1Memo_TextChanged);
            // 
            // textBoxStudent1ID
            // 
            this.textBoxStudent1ID.Location = new System.Drawing.Point(70, 62);
            this.textBoxStudent1ID.Name = "textBoxStudent1ID";
            this.textBoxStudent1ID.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent1ID.TabIndex = 8;
            this.textBoxStudent1ID.TextChanged += new System.EventHandler(this.textBoxStudent1ID_TextChanged);
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(70, 31);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent1Name.TabIndex = 7;
            this.textBoxStudent1Name.TextChanged += new System.EventHandler(this.textBoxStudent1Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "메모";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "성별";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "학번";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStudent2Delete);
            this.groupBox3.Controls.Add(this.buttonStudent2Save);
            this.groupBox3.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBox3.Controls.Add(this.textBoxStudent2Memo);
            this.groupBox3.Controls.Add(this.textBoxStudent2ID);
            this.groupBox3.Controls.Add(this.textBoxStudent2Name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(281, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 313);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생2";
            // 
            // buttonStudent2Delete
            // 
            this.buttonStudent2Delete.Location = new System.Drawing.Point(70, 266);
            this.buttonStudent2Delete.Name = "buttonStudent2Delete";
            this.buttonStudent2Delete.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent2Delete.TabIndex = 12;
            this.buttonStudent2Delete.Text = "삭제";
            this.buttonStudent2Delete.UseVisualStyleBackColor = true;
            this.buttonStudent2Delete.Click += new System.EventHandler(this.buttonStudent2Delete_Click);
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(70, 237);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent2Save.TabIndex = 11;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(70, 93);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent2Gender.TabIndex = 10;
            this.comboBoxStudent2Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent2Gender_SelectedIndexChanged);
            // 
            // textBoxStudent2Memo
            // 
            this.textBoxStudent2Memo.Location = new System.Drawing.Point(70, 122);
            this.textBoxStudent2Memo.Multiline = true;
            this.textBoxStudent2Memo.Name = "textBoxStudent2Memo";
            this.textBoxStudent2Memo.Size = new System.Drawing.Size(121, 109);
            this.textBoxStudent2Memo.TabIndex = 9;
            this.textBoxStudent2Memo.TextChanged += new System.EventHandler(this.textBoxStudent2Memo_TextChanged);
            // 
            // textBoxStudent2ID
            // 
            this.textBoxStudent2ID.Location = new System.Drawing.Point(70, 62);
            this.textBoxStudent2ID.Name = "textBoxStudent2ID";
            this.textBoxStudent2ID.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent2ID.TabIndex = 8;
            this.textBoxStudent2ID.TextChanged += new System.EventHandler(this.textBoxStudent2ID_TextChanged);
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(70, 31);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent2Name.TabIndex = 7;
            this.textBoxStudent2Name.TextChanged += new System.EventHandler(this.textBoxStudent2Name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "메모";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "성별";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "학번";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "이름";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonStudent3Delete);
            this.groupBox4.Controls.Add(this.buttonStudent3Save);
            this.groupBox4.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBox4.Controls.Add(this.textBoxStudent3Memo);
            this.groupBox4.Controls.Add(this.textBoxStudent3ID);
            this.groupBox4.Controls.Add(this.textBoxStudent3Name);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(537, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 313);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "학생3";
            // 
            // buttonStudent3Delete
            // 
            this.buttonStudent3Delete.Location = new System.Drawing.Point(70, 266);
            this.buttonStudent3Delete.Name = "buttonStudent3Delete";
            this.buttonStudent3Delete.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent3Delete.TabIndex = 12;
            this.buttonStudent3Delete.Text = "삭제";
            this.buttonStudent3Delete.UseVisualStyleBackColor = true;
            this.buttonStudent3Delete.Click += new System.EventHandler(this.buttonStudent3Delete_Click);
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(70, 237);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(121, 23);
            this.buttonStudent3Save.TabIndex = 11;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(70, 93);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudent3Gender.TabIndex = 10;
            this.comboBoxStudent3Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent3Gender_SelectedIndexChanged);
            // 
            // textBoxStudent3Memo
            // 
            this.textBoxStudent3Memo.Location = new System.Drawing.Point(70, 122);
            this.textBoxStudent3Memo.Multiline = true;
            this.textBoxStudent3Memo.Name = "textBoxStudent3Memo";
            this.textBoxStudent3Memo.Size = new System.Drawing.Size(121, 109);
            this.textBoxStudent3Memo.TabIndex = 9;
            this.textBoxStudent3Memo.TextChanged += new System.EventHandler(this.textBoxStudent3Memo_TextChanged);
            // 
            // textBoxStudent3ID
            // 
            this.textBoxStudent3ID.Location = new System.Drawing.Point(70, 62);
            this.textBoxStudent3ID.Name = "textBoxStudent3ID";
            this.textBoxStudent3ID.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent3ID.TabIndex = 8;
            this.textBoxStudent3ID.TextChanged += new System.EventHandler(this.textBoxStudent3ID_TextChanged);
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(70, 31);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(121, 25);
            this.textBoxStudent3Name.TabIndex = 7;
            this.textBoxStudent3Name.TextChanged += new System.EventHandler(this.textBoxStudent3Name_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "메모";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "성별";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "학번";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "이름";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCurrentSaveStudent;
        private System.Windows.Forms.CheckBox checkBoxAutoLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStudent1Delete;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.TextBox textBoxStudent1Memo;
        private System.Windows.Forms.TextBox textBoxStudent1ID;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStudent2Delete;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.TextBox textBoxStudent2Memo;
        private System.Windows.Forms.TextBox textBoxStudent2ID;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonStudent3Delete;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.TextBox textBoxStudent3Memo;
        private System.Windows.Forms.TextBox textBoxStudent3ID;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

