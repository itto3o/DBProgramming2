
namespace MarketBrowser
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
            this.buttonOpenCSV = new System.Windows.Forms.Button();
            this.textBoxCSVViewer = new System.Windows.Forms.TextBox();
            this.listBoxHeaders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchKeyword = new System.Windows.Forms.TextBox();
            this.textBoxSearchResult = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenCSV
            // 
            this.buttonOpenCSV.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenCSV.Name = "buttonOpenCSV";
            this.buttonOpenCSV.Size = new System.Drawing.Size(159, 51);
            this.buttonOpenCSV.TabIndex = 0;
            this.buttonOpenCSV.Text = "CSV 열기";
            this.buttonOpenCSV.UseVisualStyleBackColor = true;
            this.buttonOpenCSV.Click += new System.EventHandler(this.buttonOpenCSV_Click);
            // 
            // textBoxCSVViewer
            // 
            this.textBoxCSVViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCSVViewer.Location = new System.Drawing.Point(192, 319);
            this.textBoxCSVViewer.Multiline = true;
            this.textBoxCSVViewer.Name = "textBoxCSVViewer";
            this.textBoxCSVViewer.Size = new System.Drawing.Size(596, 119);
            this.textBoxCSVViewer.TabIndex = 1;
            // 
            // listBoxHeaders
            // 
            this.listBoxHeaders.FormattingEnabled = true;
            this.listBoxHeaders.ItemHeight = 15;
            this.listBoxHeaders.Location = new System.Drawing.Point(26, 119);
            this.listBoxHeaders.Name = "listBoxHeaders";
            this.listBoxHeaders.Size = new System.Drawing.Size(130, 319);
            this.listBoxHeaders.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "컬럼 헤더 리스트";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "검색 키워드";
            // 
            // textBoxSearchKeyword
            // 
            this.textBoxSearchKeyword.Location = new System.Drawing.Point(220, 119);
            this.textBoxSearchKeyword.Name = "textBoxSearchKeyword";
            this.textBoxSearchKeyword.Size = new System.Drawing.Size(100, 25);
            this.textBoxSearchKeyword.TabIndex = 5;
            // 
            // textBoxSearchResult
            // 
            this.textBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchResult.Location = new System.Drawing.Point(192, 195);
            this.textBoxSearchResult.Multiline = true;
            this.textBoxSearchResult.Name = "textBoxSearchResult";
            this.textBoxSearchResult.Size = new System.Drawing.Size(596, 118);
            this.textBoxSearchResult.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(220, 150);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 39);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "검색하기";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "SELECT * FROM TABLE WHERE COL like \'%Keyword%\'";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(420, 119);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchResult);
            this.Controls.Add(this.textBoxSearchKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxHeaders);
            this.Controls.Add(this.textBoxCSVViewer);
            this.Controls.Add(this.buttonOpenCSV);
            this.Name = "Form1";
            this.Text = "CSV 검색기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenCSV;
        private System.Windows.Forms.TextBox textBoxCSVViewer;
        private System.Windows.Forms.ListBox listBoxHeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchKeyword;
        private System.Windows.Forms.TextBox textBoxSearchResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInsert;
    }
}

