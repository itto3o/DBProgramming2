
namespace DBP_Quiz
{
    partial class SaleHistoryViewForm
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
            this.dataGridViewSaleHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSaleHistory
            // 
            this.dataGridViewSaleHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSaleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleHistory.Location = new System.Drawing.Point(-4, -4);
            this.dataGridViewSaleHistory.Name = "dataGridViewSaleHistory";
            this.dataGridViewSaleHistory.RowHeadersWidth = 51;
            this.dataGridViewSaleHistory.RowTemplate.Height = 27;
            this.dataGridViewSaleHistory.Size = new System.Drawing.Size(806, 456);
            this.dataGridViewSaleHistory.TabIndex = 0;
            // 
            // SaleHistoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSaleHistory);
            this.Name = "SaleHistoryViewForm";
            this.Text = "SaleHistoryViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSaleHistory;
    }
}