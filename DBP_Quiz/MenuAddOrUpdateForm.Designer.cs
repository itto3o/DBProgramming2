
namespace DBP_Quiz
{
    partial class MenuAddOrUpdateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.pictureBoxMenuImage = new System.Windows.Forms.PictureBox();
            this.textBoxMenuPrice = new System.Windows.Forms.TextBox();
            this.textBoxMenuName = new System.Windows.Forms.TextBox();
            this.buttonSaveMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "추가 및 수정할 메뉴 정보를 입력해주세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "메뉴 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "메뉴 가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "메뉴 사진";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadImage);
            this.groupBox1.Controls.Add(this.pictureBoxMenuImage);
            this.groupBox1.Controls.Add(this.textBoxMenuPrice);
            this.groupBox1.Controls.Add(this.textBoxMenuName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴 정보";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(294, 88);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadImage.TabIndex = 7;
            this.buttonLoadImage.Text = "불러오기";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // pictureBoxMenuImage
            // 
            this.pictureBoxMenuImage.Location = new System.Drawing.Point(107, 88);
            this.pictureBoxMenuImage.Name = "pictureBoxMenuImage";
            this.pictureBoxMenuImage.Size = new System.Drawing.Size(171, 136);
            this.pictureBoxMenuImage.TabIndex = 6;
            this.pictureBoxMenuImage.TabStop = false;
            // 
            // textBoxMenuPrice
            // 
            this.textBoxMenuPrice.Location = new System.Drawing.Point(107, 56);
            this.textBoxMenuPrice.Name = "textBoxMenuPrice";
            this.textBoxMenuPrice.Size = new System.Drawing.Size(100, 25);
            this.textBoxMenuPrice.TabIndex = 5;
            // 
            // textBoxMenuName
            // 
            this.textBoxMenuName.Location = new System.Drawing.Point(107, 28);
            this.textBoxMenuName.Name = "textBoxMenuName";
            this.textBoxMenuName.Size = new System.Drawing.Size(100, 25);
            this.textBoxMenuName.TabIndex = 4;
            // 
            // buttonSaveMenu
            // 
            this.buttonSaveMenu.Location = new System.Drawing.Point(329, 298);
            this.buttonSaveMenu.Name = "buttonSaveMenu";
            this.buttonSaveMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMenu.TabIndex = 5;
            this.buttonSaveMenu.Text = "저장";
            this.buttonSaveMenu.UseVisualStyleBackColor = true;
            this.buttonSaveMenu.Click += new System.EventHandler(this.buttonSaveMenu_Click);
            // 
            // MenuAddOrUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 333);
            this.Controls.Add(this.buttonSaveMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MenuAddOrUpdateForm";
            this.Text = "메뉴 추가 및 수정";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAddOrUpdateForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxMenuImage;
        private System.Windows.Forms.TextBox textBoxMenuPrice;
        private System.Windows.Forms.TextBox textBoxMenuName;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonSaveMenu;
    }
}