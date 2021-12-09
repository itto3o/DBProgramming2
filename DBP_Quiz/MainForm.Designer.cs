
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelAdminView = new System.Windows.Forms.Label();
            this.labelCasherView = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMenuDaily = new System.Windows.Forms.DataGridView();
            this.dataGridViewMenuMonthly = new System.Windows.Forms.DataGridView();
            this.menuStripAdmin = new System.Windows.Forms.MenuStrip();
            this.userLogCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인로그아웃확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴변경정보확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문정보변경확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.menuStripCasher = new System.Windows.Forms.MenuStrip();
            this.지난내역보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUserInfoChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuMonthly)).BeginInit();
            this.menuStripAdmin.SuspendLayout();
            this.menuStripCasher.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUserDay
            // 
            this.dataGridViewUserDay.AllowUserToDeleteRows = false;
            this.dataGridViewUserDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUserDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDay.Location = new System.Drawing.Point(52, 133);
            this.dataGridViewUserDay.Name = "dataGridViewUserDay";
            this.dataGridViewUserDay.RowHeadersWidth = 51;
            this.dataGridViewUserDay.RowTemplate.Height = 27;
            this.dataGridViewUserDay.Size = new System.Drawing.Size(479, 233);
            this.dataGridViewUserDay.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(512, 35);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 15);
            this.labelWelcome.TabIndex = 6;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(675, 31);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelAdminView
            // 
            this.labelAdminView.AutoSize = true;
            this.labelAdminView.Location = new System.Drawing.Point(49, 104);
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
            this.dateTimePickerDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(52, 65);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // dataGridViewMenuDaily
            // 
            this.dataGridViewMenuDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenuDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuDaily.Location = new System.Drawing.Point(52, 385);
            this.dataGridViewMenuDaily.Name = "dataGridViewMenuDaily";
            this.dataGridViewMenuDaily.RowHeadersWidth = 51;
            this.dataGridViewMenuDaily.RowTemplate.Height = 27;
            this.dataGridViewMenuDaily.Size = new System.Drawing.Size(479, 233);
            this.dataGridViewMenuDaily.TabIndex = 18;
            // 
            // dataGridViewMenuMonthly
            // 
            this.dataGridViewMenuMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenuMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuMonthly.Location = new System.Drawing.Point(52, 634);
            this.dataGridViewMenuMonthly.Name = "dataGridViewMenuMonthly";
            this.dataGridViewMenuMonthly.RowHeadersWidth = 51;
            this.dataGridViewMenuMonthly.RowTemplate.Height = 27;
            this.dataGridViewMenuMonthly.Size = new System.Drawing.Size(479, 233);
            this.dataGridViewMenuMonthly.TabIndex = 19;
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLogCheck,
            this.메뉴관리ToolStripMenuItem});
            this.menuStripAdmin.Location = new System.Drawing.Point(0, 28);
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(791, 28);
            this.menuStripAdmin.TabIndex = 20;
            this.menuStripAdmin.Text = "menuStrip1";
            // 
            // userLogCheck
            // 
            this.userLogCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인로그아웃확인ToolStripMenuItem,
            this.메뉴변경정보확인ToolStripMenuItem,
            this.주문정보변경확인ToolStripMenuItem});
            this.userLogCheck.Name = "userLogCheck";
            this.userLogCheck.Size = new System.Drawing.Size(123, 24);
            this.userLogCheck.Text = "유저 로그 확인";
            // 
            // 로그인로그아웃확인ToolStripMenuItem
            // 
            this.로그인로그아웃확인ToolStripMenuItem.Name = "로그인로그아웃확인ToolStripMenuItem";
            this.로그인로그아웃확인ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.로그인로그아웃확인ToolStripMenuItem.Text = "로그인/로그아웃 확인";
            this.로그인로그아웃확인ToolStripMenuItem.Click += new System.EventHandler(this.로그인로그아웃확인ToolStripMenuItem_Click);
            // 
            // 메뉴변경정보확인ToolStripMenuItem
            // 
            this.메뉴변경정보확인ToolStripMenuItem.Name = "메뉴변경정보확인ToolStripMenuItem";
            this.메뉴변경정보확인ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.메뉴변경정보확인ToolStripMenuItem.Text = "메뉴 정보 변경 확인";
            this.메뉴변경정보확인ToolStripMenuItem.Click += new System.EventHandler(this.메뉴변경정보확인ToolStripMenuItem_Click);
            // 
            // 주문정보변경확인ToolStripMenuItem
            // 
            this.주문정보변경확인ToolStripMenuItem.Name = "주문정보변경확인ToolStripMenuItem";
            this.주문정보변경확인ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.주문정보변경확인ToolStripMenuItem.Text = "주문 정보 변경 확인";
            this.주문정보변경확인ToolStripMenuItem.Click += new System.EventHandler(this.주문정보변경확인ToolStripMenuItem_Click);
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴추가ToolStripMenuItem,
            this.메뉴수정ToolStripMenuItem});
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            // 
            // 메뉴추가ToolStripMenuItem
            // 
            this.메뉴추가ToolStripMenuItem.Name = "메뉴추가ToolStripMenuItem";
            this.메뉴추가ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.메뉴추가ToolStripMenuItem.Text = "추가";
            this.메뉴추가ToolStripMenuItem.Click += new System.EventHandler(this.메뉴수정ToolStripMenuItem_Click);
            // 
            // 메뉴수정ToolStripMenuItem
            // 
            this.메뉴수정ToolStripMenuItem.Name = "메뉴수정ToolStripMenuItem";
            this.메뉴수정ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.메뉴수정ToolStripMenuItem.Text = "수정";
            this.메뉴수정ToolStripMenuItem.Click += new System.EventHandler(this.메뉴수정ToolStripMenuItem_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(179, 104);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(102, 15);
            this.labelTotalPrice.TabIndex = 21;
            this.labelTotalPrice.Text = "총 결제 금액 :";
            // 
            // menuStripCasher
            // 
            this.menuStripCasher.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCasher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.지난내역보기ToolStripMenuItem});
            this.menuStripCasher.Location = new System.Drawing.Point(0, 0);
            this.menuStripCasher.Name = "menuStripCasher";
            this.menuStripCasher.Size = new System.Drawing.Size(791, 28);
            this.menuStripCasher.TabIndex = 22;
            this.menuStripCasher.Text = "menuStrip1";
            // 
            // 지난내역보기ToolStripMenuItem
            // 
            this.지난내역보기ToolStripMenuItem.Name = "지난내역보기ToolStripMenuItem";
            this.지난내역보기ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.지난내역보기ToolStripMenuItem.Text = "지난 내역 보기";
            this.지난내역보기ToolStripMenuItem.Click += new System.EventHandler(this.지난내역보기ToolStripMenuItem_Click);
            // 
            // buttonUserInfoChange
            // 
            this.buttonUserInfoChange.Location = new System.Drawing.Point(629, 65);
            this.buttonUserInfoChange.Name = "buttonUserInfoChange";
            this.buttonUserInfoChange.Size = new System.Drawing.Size(121, 23);
            this.buttonUserInfoChange.TabIndex = 23;
            this.buttonUserInfoChange.Text = "회원 정보 변경";
            this.buttonUserInfoChange.UseVisualStyleBackColor = true;
            this.buttonUserInfoChange.Click += new System.EventHandler(this.buttonUserInfoChange_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(791, 892);
            this.Controls.Add(this.buttonUserInfoChange);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.dataGridViewMenuMonthly);
            this.Controls.Add(this.dataGridViewMenuDaily);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelCasherView);
            this.Controls.Add(this.labelAdminView);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.dataGridViewUserDay);
            this.Controls.Add(this.menuStripAdmin);
            this.Controls.Add(this.menuStripCasher);
            this.MainMenuStrip = this.menuStripAdmin;
            this.Name = "MainForm";
            this.Text = "국밥집 메인 화면";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuMonthly)).EndInit();
            this.menuStripAdmin.ResumeLayout(false);
            this.menuStripAdmin.PerformLayout();
            this.menuStripCasher.ResumeLayout(false);
            this.menuStripCasher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserDay;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelAdminView;
        private System.Windows.Forms.Label labelCasherView;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DataGridView dataGridViewMenuDaily;
        private System.Windows.Forms.DataGridView dataGridViewMenuMonthly;
        private System.Windows.Forms.MenuStrip menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogCheck;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.MenuStrip menuStripCasher;
        private System.Windows.Forms.ToolStripMenuItem 지난내역보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인로그아웃확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴변경정보확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문정보변경확인ToolStripMenuItem;
        private System.Windows.Forms.Button buttonUserInfoChange;
    }
}

