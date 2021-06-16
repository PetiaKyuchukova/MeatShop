using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeatShop;

namespace MeatShopForms.Forms
{
    public partial class PorkSpicesForm : Form
    {
        Pork porkMeat1;
        List<CheckBox> checkBoxesList = new List<CheckBox>();
        CheckBox checkBox1 = new CheckBox();
        public PorkSpicesForm()
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public void AddMeat(Meat porkMeat)
        {
            porkMeat1 = (Pork)porkMeat;
            int x = 15;
            int y = 0;
            foreach (KeyValuePair<Spices, double> spice in porkMeat1.AvailableSpicesDictionary)
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
            checkBox1.Name = "Mince";
            checkBox1.Width = 1000;
            checkBox1.Text = $"Mince: price + {Pork.mincePercentSurcharge * 100}%";
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
                    porkMeat1.SelectedSpicesList.Add(spice);
                }
                else if (!checkBox.Checked)
                {
                    porkMeat1.SelectedSpicesList.Remove(spice);
                }
            }
            porkMeat1.PriceAfterSpice();
            if (checkBox1.Checked)
            {
                porkMeat1.MinceSelected();
            }          
            Close();
        }

        private void PorkSpicesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
