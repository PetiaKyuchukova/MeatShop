namespace MeatShopForms
{
    partial class FormAssortment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssortment));
            this.labelAssortment = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonInterimReport = new System.Windows.Forms.Button();
            this.table_Layout_Assortment = new System.Windows.Forms.TableLayoutPanel();
            this.MonthlyReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAssortment
            // 
            this.labelAssortment.AutoSize = true;
            this.labelAssortment.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssortment.ForeColor = System.Drawing.Color.Black;
            this.labelAssortment.Location = new System.Drawing.Point(30, 30);
            this.labelAssortment.Name = "labelAssortment";
            this.labelAssortment.Size = new System.Drawing.Size(124, 21);
            this.labelAssortment.TabIndex = 1;
            this.labelAssortment.Text = "Assortment";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.ForeColor = System.Drawing.Color.Black;
            this.buttonSell.Location = new System.Drawing.Point(34, 301);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(192, 55);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "Sell\r\n";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.ButtonSold_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(238, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 55);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonInterimReport
            // 
            this.buttonInterimReport.Location = new System.Drawing.Point(34, 392);
            this.buttonInterimReport.Name = "buttonInterimReport";
            this.buttonInterimReport.Size = new System.Drawing.Size(192, 55);
            this.buttonInterimReport.TabIndex = 4;
            this.buttonInterimReport.Text = "Interim report";
            this.buttonInterimReport.UseVisualStyleBackColor = true;
            this.buttonInterimReport.Click += new System.EventHandler(this.ButtonInterimReport_Click);
            // 
            // table_Layout_Assortment
            // 
            this.table_Layout_Assortment.ColumnCount = 3;
            this.table_Layout_Assortment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.44444F));
            this.table_Layout_Assortment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.55556F));
            this.table_Layout_Assortment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.table_Layout_Assortment.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Layout_Assortment.Location = new System.Drawing.Point(34, 64);
            this.table_Layout_Assortment.MaximumSize = new System.Drawing.Size(396, 208);
            this.table_Layout_Assortment.MinimumSize = new System.Drawing.Size(396, 208);
            this.table_Layout_Assortment.Name = "table_Layout_Assortment";
            this.table_Layout_Assortment.RowCount = 1;
            this.table_Layout_Assortment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_Layout_Assortment.Size = new System.Drawing.Size(396, 208);
            this.table_Layout_Assortment.TabIndex = 5;
            this.table_Layout_Assortment.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Layout_Assortment_Paint);
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Location = new System.Drawing.Point(238, 392);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Size = new System.Drawing.Size(192, 55);
            this.MonthlyReport.TabIndex = 7;
            this.MonthlyReport.Text = "Monthly report";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            this.MonthlyReport.Click += new System.EventHandler(this.MonthlyReport_Click);
            // 
            // FormAssortment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(457, 477);
            this.Controls.Add(this.MonthlyReport);
            this.Controls.Add(this.table_Layout_Assortment);
            this.Controls.Add(this.buttonInterimReport);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.labelAssortment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(479, 533);
            this.MinimumSize = new System.Drawing.Size(479, 533);
            this.Name = "FormAssortment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meat Shop";
            this.Load += new System.EventHandler(this.FormAssortment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAssortment;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInterimReport;
        private System.Windows.Forms.Button MonthlyReport;
        public System.Windows.Forms.TableLayoutPanel table_Layout_Assortment;
    }
}

