
namespace DBP_Quiz
{
    partial class SaleChangeCheckForm
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
            this.comboBoxUserList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSaleChangeBefore = new System.Windows.Forms.DataGridView();
            this.dataGridViewSaleChangeAfter = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleChangeBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleChangeAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserList
            // 
            this.comboBoxUserList.FormattingEnabled = true;
            this.comboBoxUserList.Location = new System.Drawing.Point(44, 65);
            this.comboBoxUserList.Name = "comboBoxUserList";
            this.comboBoxUserList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUserList.TabIndex = 0;
            this.comboBoxUserList.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "유저 목록";
            // 
            // dataGridViewSaleChangeBefore
            // 
            this.dataGridViewSaleChangeBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleChangeBefore.Location = new System.Drawing.Point(44, 94);
            this.dataGridViewSaleChangeBefore.Name = "dataGridViewSaleChangeBefore";
            this.dataGridViewSaleChangeBefore.RowHeadersWidth = 51;
            this.dataGridViewSaleChangeBefore.RowTemplate.Height = 27;
            this.dataGridViewSaleChangeBefore.Size = new System.Drawing.Size(716, 180);
            this.dataGridViewSaleChangeBefore.TabIndex = 2;
            // 
            // dataGridViewSaleChangeAfter
            // 
            this.dataGridViewSaleChangeAfter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleChangeAfter.Location = new System.Drawing.Point(44, 332);
            this.dataGridViewSaleChangeAfter.Name = "dataGridViewSaleChangeAfter";
            this.dataGridViewSaleChangeAfter.RowHeadersWidth = 51;
            this.dataGridViewSaleChangeAfter.RowTemplate.Height = 27;
            this.dataGridViewSaleChangeAfter.Size = new System.Drawing.Size(716, 180);
            this.dataGridViewSaleChangeAfter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "변경 후";
            // 
            // SaleChangeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSaleChangeAfter);
            this.Controls.Add(this.dataGridViewSaleChangeBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUserList);
            this.Name = "SaleChangeCheckForm";
            this.Text = "SaleChangeCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleChangeBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleChangeAfter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSaleChangeBefore;
        private System.Windows.Forms.DataGridView dataGridViewSaleChangeAfter;
        private System.Windows.Forms.Label label2;
    }
}