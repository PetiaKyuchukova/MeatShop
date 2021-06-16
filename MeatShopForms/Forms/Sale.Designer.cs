namespace MeatShopForms
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.KindOfMeat = new System.Windows.Forms.Label();
            this.Kg = new System.Windows.Forms.Label();
            this.textBoxKgMeat = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RB_Chicken = new System.Windows.Forms.RadioButton();
            this.RB_Beef = new System.Windows.Forms.RadioButton();
            this.RB_Pork = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KindOfMeat
            // 
            this.KindOfMeat.AutoSize = true;
            this.KindOfMeat.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KindOfMeat.Location = new System.Drawing.Point(20, 22);
            this.KindOfMeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KindOfMeat.Name = "KindOfMeat";
            this.KindOfMeat.Size = new System.Drawing.Size(145, 24);
            this.KindOfMeat.TabIndex = 0;
            this.KindOfMeat.Text = "Kind of meat";
            this.KindOfMeat.Click += new System.EventHandler(this.KindOfMeat_Click);
            // 
            // Kg
            // 
            this.Kg.AutoSize = true;
            this.Kg.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kg.Location = new System.Drawing.Point(27, 193);
            this.Kg.Name = "Kg";
            this.Kg.Size = new System.Drawing.Size(31, 19);
            this.Kg.TabIndex = 2;
            this.Kg.Text = "Kg";
            // 
            // textBoxKgMeat
            // 
            this.textBoxKgMeat.Location = new System.Drawing.Point(24, 216);
            this.textBoxKgMeat.Name = "textBoxKgMeat";
            this.textBoxKgMeat.Size = new System.Drawing.Size(94, 27);
            this.textBoxKgMeat.TabIndex = 4;
            this.textBoxKgMeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKgMeat_KeyDown);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(198, 193);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 19);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalBox.Location = new System.Drawing.Point(202, 217);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(94, 26);
            this.totalBox.TabIndex = 7;
            // 
            // RB_Chicken
            // 
            this.RB_Chicken.AutoSize = true;
            this.RB_Chicken.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Chicken.Location = new System.Drawing.Point(24, 61);
            this.RB_Chicken.Name = "RB_Chicken";
            this.RB_Chicken.Size = new System.Drawing.Size(97, 27);
            this.RB_Chicken.TabIndex = 8;
            this.RB_Chicken.TabStop = true;
            this.RB_Chicken.Text = "Chicken";
            this.RB_Chicken.UseVisualStyleBackColor = true;
            this.RB_Chicken.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RB_Beef
            // 
            this.RB_Beef.AutoSize = true;
            this.RB_Beef.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Beef.Location = new System.Drawing.Point(24, 94);
            this.RB_Beef.Name = "RB_Beef";
            this.RB_Beef.Size = new System.Drawing.Size(71, 27);
            this.RB_Beef.TabIndex = 9;
            this.RB_Beef.TabStop = true;
            this.RB_Beef.Text = "Beef";
            this.RB_Beef.UseVisualStyleBackColor = true;
            this.RB_Beef.CheckedChanged += new System.EventHandler(this.RB_Beef_CheckedChanged);
            // 
            // RB_Pork
            // 
            this.RB_Pork.AutoSize = true;
            this.RB_Pork.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Pork.Location = new System.Drawing.Point(24, 127);
            this.RB_Pork.Name = "RB_Pork";
            this.RB_Pork.Size = new System.Drawing.Size(74, 27);
            this.RB_Pork.TabIndex = 10;
            this.RB_Pork.TabStop = true;
            this.RB_Pork.Text = "Pork";
            this.RB_Pork.UseVisualStyleBackColor = true;
            this.RB_Pork.CheckedChanged += new System.EventHandler(this.RB_Pork_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(202, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(25, 270);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(93, 35);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 304);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RB_Pork);
            this.Controls.Add(this.RB_Beef);
            this.Controls.Add(this.RB_Chicken);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxKgMeat);
            this.Controls.Add(this.Kg);
            this.Controls.Add(this.KindOfMeat);
            this.Font = new System.Drawing.Font("Symbol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(330, 360);
            this.MinimumSize = new System.Drawing.Size(330, 360);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KindOfMeat;
        private System.Windows.Forms.Label Kg;
        private System.Windows.Forms.TextBox textBoxKgMeat;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox totalBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton RB_Chicken;
        private System.Windows.Forms.RadioButton RB_Beef;
        private System.Windows.Forms.RadioButton RB_Pork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCalculate;
    }
}