
namespace DBP_Quiz
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
            this.dataGridViewUserDay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUserPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSunDae = new System.Windows.Forms.Button();
            this.buttonDaesi = new System.Windows.Forms.Button();
            this.buttonDdaro = new System.Windows.Forms.Button();
            this.labelAdminView = new System.Windows.Forms.Label();
            this.labelCasherView = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMenuDaily = new System.Windows.Forms.DataGridView();
            this.dataGridViewMenuMonthly = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuMonthly)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserDay
            // 
            this.dataGridViewUserDay.AllowUserToDeleteRows = false;
            this.dataGridViewUserDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUserDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDay.Location = new System.Drawing.Point(42, 273);
            this.dataGridViewUserDay.Name = "dataGridViewUserDay";
            this.dataGridViewUserDay.RowHeadersWidth = 51;
            this.dataGridViewUserDay.RowTemplate.Height = 27;
            this.dataGridViewUserDay.Size = new System.Drawing.Size(329, 233);
            this.dataGridViewUserDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(50, 17);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 25);
            this.textBoxUserID.TabIndex = 2;
            // 
            // textBoxUserPW
            // 
            this.textBoxUserPW.Location = new System.Drawing.Point(213, 17);
            this.textBoxUserPW.Name = "textBoxUserPW";
            this.textBoxUserPW.Size = new System.Drawing.Size(100, 25);
            this.textBoxUserPW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(337, 16);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(553, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 15);
            this.labelWelcome.TabIndex = 6;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(713, 16);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSunDae
            // 
            this.buttonSunDae.Location = new System.Drawing.Point(75, 133);
            this.buttonSunDae.Name = "buttonSunDae";
            this.buttonSunDae.Size = new System.Drawing.Size(171, 67);
            this.buttonSunDae.TabIndex = 8;
            this.buttonSunDae.Text = "순대국밥";
            this.buttonSunDae.UseVisualStyleBackColor = true;
            this.buttonSunDae.Click += new System.EventHandler(this.buttonSunDae_Click);
            // 
            // buttonDaesi
            // 
            this.buttonDaesi.Location = new System.Drawing.Point(305, 133);
            this.buttonDaesi.Name = "buttonDaesi";
            this.buttonDaesi.Size = new System.Drawing.Size(171, 67);
            this.buttonDaesi.TabIndex = 9;
            this.buttonDaesi.Text = "돼지국밥";
            this.buttonDaesi.UseVisualStyleBackColor = true;
            this.buttonDaesi.Click += new System.EventHandler(this.buttonDaesi_Click);
            // 
            // buttonDdaro
            // 
            this.buttonDdaro.Location = new System.Drawing.Point(537, 133);
            this.buttonDdaro.Name = "buttonDdaro";
            this.buttonDdaro.Size = new System.Drawing.Size(171, 67);
            this.buttonDdaro.TabIndex = 10;
            this.buttonDdaro.Text = "따로국밥";
            this.buttonDdaro.UseVisualStyleBackColor = true;
            this.buttonDdaro.Click += new System.EventHandler(this.buttonDdaro_Click);
            // 
            // labelAdminView
            // 
            this.labelAdminView.AutoSize = true;
            this.labelAdminView.Location = new System.Drawing.Point(43, 248);
            this.labelAdminView.Name = "labelAdminView";
            this.labelAdminView.Size = new System.Drawing.Size(102, 15);
            this.labelAdminView.TabIndex = 12;
            this.labelAdminView.Text = "관리자용 화면";
            // 
            // labelCasherView
            // 
            this.labelCasherView.AutoSize = true;
            this.labelCasherView.Location = new System.Drawing.Point(49, 104);
            this.labelCasherView.Name = "labelCasherView";
            this.labelCasherView.Size = new System.Drawing.Size(87, 15);
            this.labelCasherView.TabIndex = 13;
            this.labelCasherView.Text = "캐셔용 화면";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(52, 65);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "6000원";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "6000원";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "6000원";
            // 
            // dataGridViewMenuDaily
            // 
            this.dataGridViewMenuDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenuDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuDaily.Location = new System.Drawing.Point(409, 273);
            this.dataGridViewMenuDaily.Name = "dataGridViewMenuDaily";
            this.dataGridViewMenuDaily.RowHeadersWidth = 51;
            this.dataGridViewMenuDaily.RowTemplate.Height = 27;
            this.dataGridViewMenuDaily.Size = new System.Drawing.Size(329, 233);
            this.dataGridViewMenuDaily.TabIndex = 18;
            // 
            // dataGridViewMenuMonthly
            // 
            this.dataGridViewMenuMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenuMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuMonthly.Location = new System.Drawing.Point(778, 273);
            this.dataGridViewMenuMonthly.Name = "dataGridViewMenuMonthly";
            this.dataGridViewMenuMonthly.RowHeadersWidth = 51;
            this.dataGridViewMenuMonthly.RowTemplate.Height = 27;
            this.dataGridViewMenuMonthly.Size = new System.Drawing.Size(329, 233);
            this.dataGridViewMenuMonthly.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 560);
            this.Controls.Add(this.dataGridViewMenuMonthly);
            this.Controls.Add(this.dataGridViewMenuDaily);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelCasherView);
            this.Controls.Add(this.labelAdminView);
            this.Controls.Add(this.buttonDdaro);
            this.Controls.Add(this.buttonDaesi);
            this.Controls.Add(this.buttonSunDae);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUserPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUserDay);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuMonthly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxUserPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSunDae;
        private System.Windows.Forms.Button buttonDaesi;
        private System.Windows.Forms.Button buttonDdaro;
        private System.Windows.Forms.Label labelAdminView;
        private System.Windows.Forms.Label labelCasherView;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMenuDaily;
        private System.Windows.Forms.DataGridView dataGridViewMenuMonthly;
    }
}

