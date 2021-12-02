
namespace DBP_Quiz
{
    partial class TableStatementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTable1 = new System.Windows.Forms.Button();
            this.buttonTable2 = new System.Windows.Forms.Button();
            this.buttonTable3 = new System.Windows.Forms.Button();
            this.buttonTable4 = new System.Windows.Forms.Button();
            this.buttonTable5 = new System.Windows.Forms.Button();
            this.buttonTable6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "앉을 테이블을 선택해주세요.";
            // 
            // buttonTable1
            // 
            this.buttonTable1.Location = new System.Drawing.Point(98, 125);
            this.buttonTable1.Name = "buttonTable1";
            this.buttonTable1.Size = new System.Drawing.Size(165, 96);
            this.buttonTable1.TabIndex = 1;
            this.buttonTable1.Tag = "1";
            this.buttonTable1.Text = "1번 테이블";
            this.buttonTable1.UseVisualStyleBackColor = true;
            this.buttonTable1.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable2
            // 
            this.buttonTable2.Location = new System.Drawing.Point(316, 125);
            this.buttonTable2.Name = "buttonTable2";
            this.buttonTable2.Size = new System.Drawing.Size(165, 96);
            this.buttonTable2.TabIndex = 2;
            this.buttonTable2.Tag = "2";
            this.buttonTable2.Text = "2번 테이블";
            this.buttonTable2.UseVisualStyleBackColor = true;
            this.buttonTable2.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable3
            // 
            this.buttonTable3.Location = new System.Drawing.Point(533, 125);
            this.buttonTable3.Name = "buttonTable3";
            this.buttonTable3.Size = new System.Drawing.Size(165, 96);
            this.buttonTable3.TabIndex = 3;
            this.buttonTable3.Tag = "3";
            this.buttonTable3.Text = "3번 테이블";
            this.buttonTable3.UseVisualStyleBackColor = true;
            this.buttonTable3.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable4
            // 
            this.buttonTable4.Location = new System.Drawing.Point(98, 271);
            this.buttonTable4.Name = "buttonTable4";
            this.buttonTable4.Size = new System.Drawing.Size(165, 96);
            this.buttonTable4.TabIndex = 4;
            this.buttonTable4.Tag = "4";
            this.buttonTable4.Text = "4번 테이블";
            this.buttonTable4.UseVisualStyleBackColor = true;
            this.buttonTable4.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable5
            // 
            this.buttonTable5.Location = new System.Drawing.Point(316, 271);
            this.buttonTable5.Name = "buttonTable5";
            this.buttonTable5.Size = new System.Drawing.Size(165, 96);
            this.buttonTable5.TabIndex = 5;
            this.buttonTable5.Tag = "5";
            this.buttonTable5.Text = "5번 테이블";
            this.buttonTable5.UseVisualStyleBackColor = true;
            this.buttonTable5.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable6
            // 
            this.buttonTable6.Location = new System.Drawing.Point(533, 271);
            this.buttonTable6.Name = "buttonTable6";
            this.buttonTable6.Size = new System.Drawing.Size(165, 96);
            this.buttonTable6.TabIndex = 6;
            this.buttonTable6.Tag = "6";
            this.buttonTable6.Text = "6번 테이블";
            this.buttonTable6.UseVisualStyleBackColor = true;
            this.buttonTable6.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // TableStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTable6);
            this.Controls.Add(this.buttonTable5);
            this.Controls.Add(this.buttonTable4);
            this.Controls.Add(this.buttonTable3);
            this.Controls.Add(this.buttonTable2);
            this.Controls.Add(this.buttonTable1);
            this.Controls.Add(this.label1);
            this.Name = "TableStatementForm";
            this.Text = "TableStatement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTable1;
        private System.Windows.Forms.Button buttonTable2;
        private System.Windows.Forms.Button buttonTable3;
        private System.Windows.Forms.Button buttonTable4;
        private System.Windows.Forms.Button buttonTable5;
        private System.Windows.Forms.Button buttonTable6;
    }
}