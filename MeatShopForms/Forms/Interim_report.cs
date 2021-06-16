using MeatShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShopForms
{
    public partial class InterimReport : Form
    {
        List<Meat> meats;
        public InterimReport(List<Meat> meats)
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.meats = meats;

            table_Layout_Report.RowCount++;
            table_Layout_Report.Controls.Add(new Label() { Text = "Meat type" }, 0, table_Layout_Report.RowCount - 1);
            table_Layout_Report.Controls.Add(new Label() { Text = "Quantity sold meat" }, 1, table_Layout_Report.RowCount - 1);
            table_Layout_Report.Controls.Add(new Label() { Text = "Profit" }, 2, table_Layout_Report.RowCount - 1);
            foreach (Meat m in meats)
            {
                table_Layout_Report.RowCount++;

                if (m is Beef)
                {
                    table_Layout_Report.Controls.Add(new Label() { Text = "Beef" }, 0, table_Layout_Report.RowCount - 1);
                }
                else if (m is Pork)
                {
                    table_Layout_Report.Controls.Add(new Label() { Text = "Pork" }, 0, table_Layout_Report.RowCount - 1);
                }
                else if (m is Chicken)
                {
                    table_Layout_Report.Controls.Add(new Label() { Text = "Chicken" }, 0, table_Layout_Report.RowCount - 1);
                }
                table_Layout_Report.Controls.Add(new Label() { Text = m.SoldMeat.ToString() }, 1, table_Layout_Report.RowCount - 1);
                table_Layout_Report.Controls.Add(new Label() { Text = Math.Round(m.Profit, 2).ToString() }, 2, table_Layout_Report.RowCount - 1);
            }

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
