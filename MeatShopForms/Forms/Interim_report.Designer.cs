namespace MeatShopForms
{
    partial class InterimReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterimReport));
            this.table_Layout_Report = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // table_Layout_Report
            // 
            this.table_Layout_Report.ColumnCount = 3;
            this.table_Layout_Report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.69908F));
            this.table_Layout_Report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.42173F));
            this.table_Layout_Report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.90735F));
            this.table_Layout_Report.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Layout_Report.Location = new System.Drawing.Point(24, 32);
            this.table_Layout_Report.Name = "table_Layout_Report";
            this.table_Layout_Report.RowCount = 2;
            this.table_Layout_Report.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_Layout_Report.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_Layout_Report.Size = new System.Drawing.Size(307, 148);
            this.table_Layout_Report.TabIndex = 1;
            // 
            // InterimReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 275);
            this.Controls.Add(this.table_Layout_Report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterimReport";
            this.Text = "Interim report";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel table_Layout_Report;
    }
}