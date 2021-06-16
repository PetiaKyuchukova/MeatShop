using MeatShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeatShopForms
{
    public partial class ChickenSpicesForm : Form
    {
        Chicken chickenMeat1;
        CheckBox checkBox1 = new CheckBox();
        List<CheckBox> checkBoxesList = new List<CheckBox>();
        public ChickenSpicesForm()
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public void AddMeat(Meat chickenMeat)
        {
            int x = 15;
            int y = 0;

            chickenMeat1 = (Chicken)chickenMeat;
            if (chickenMeat is null)
            {
                MessageBox.Show("NO");
            }
            foreach (KeyValuePair<Spices, double> spice in chickenMeat.AvailableSpicesDictionary)
            {
                y += 25;
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(x, y);
                checkBox.Name = spice.Key.ToString();
                checkBox.Text = $"{spice.Key.ToString()}: price + {spice.Value * 100}%";
                checkBox.Width = 1000;
                this.Controls.Add(checkBox);
                checkBoxesList.Add(checkBox);
            }

            y += 25;
            checkBox1.Location = new Point(x, y);
            checkBox1.Name = "Boned";
            checkBox1.Width = 1000;
            checkBox1.Text = $"Boned: price + {Chicken.bonedPercentSurcharge * 100}%";
            this.Controls.Add(checkBox1);
            
        }
        private void OK_button_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxesList)
            {
                string typeSpice = checkBox.Name;
                Spices spice = (Spices)Enum.Parse(typeof(Spices), typeSpice);

                if (checkBox.Checked)
                {
                    chickenMeat1.SelectedSpicesList.Add(spice);
                }
                else if (!checkBox.Checked)
                {
                    chickenMeat1.SelectedSpicesList.Remove(spice);
                }
            }
            chickenMeat1.PriceAfterSpice();
            if (checkBox1.Checked)
            {
                chickenMeat1.BonedSelected();
            }
            Close();
        }
    }
}
