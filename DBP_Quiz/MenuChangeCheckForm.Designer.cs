
namespace DBP_Quiz
{
    partial class MenuChangeCheckForm
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
            this.comboBoxMenuList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMenuChangeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuChangeList)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMenuList
            // 
            this.comboBoxMenuList.FormattingEnabled = true;
            this.comboBoxMenuList.Location = new System.Drawing.Point(35, 59);
            this.comboBoxMenuList.Name = "comboBoxMenuList";
            this.comboBoxMenuList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMenuList.TabIndex = 0;
            this.comboBoxMenuList.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenuList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴 이름";
            // 
            // dataGridViewMenuChangeList
            // 
            this.dataGridViewMenuChangeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuChangeList.Location = new System.Drawing.Point(35, 106);
            this.dataGridViewMenuChangeList.Name = "dataGridViewMenuChangeList";
            this.dataGridViewMenuChangeList.RowHeadersWidth = 51;
            this.dataGridViewMenuChangeList.RowTemplate.Height = 27;
            this.dataGridViewMenuChangeList.Size = new System.Drawing.Size(730, 299);
            this.dataGridViewMenuChangeList.TabIndex = 2;
            // 
            // MenuChangeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMenuChangeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMenuList);
            this.Name = "MenuChangeCheckForm";
            this.Text = "MenuChangeCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuChangeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMenuList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMenuChangeList;
    }
}