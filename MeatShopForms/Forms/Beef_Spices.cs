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

namespace MeatShopForms.Forms
{
    public partial class BeefSpicesForm : Form
    {
        Beef beefMeat1;
        List<CheckBox> checkBoxesList = new List<CheckBox>();
        CheckBox checkBox1 = new CheckBox();
        public BeefSpicesForm()
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public void AddMeat(Meat beefMeat)
        {
            beefMeat1 = (Beef)beefMeat;
            int x = 15;
            int y = 0;
            foreach (KeyValuePair<Spices, double> spice in beefMeat.AvailableSpicesDictionary)
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
            checkBox1.Text = $"Mince: price + {Beef.mincePercentSurcharge * 100}%";
            this.Controls.Add(checkBox1);
        }      
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxesList)
            {
                string typeSpice = checkBox.Name;
                Spices spice = (Spices)Enum.Parse(typeof(Spices), typeSpice);

                if (checkBox.Checked)
                {
                    beefMeat1.SelectedSpicesList.Add(spice);
                }
                else if (!checkBox.Checked)
                {
                    beefMeat1.SelectedSpicesList.Remove(spice);
                }
            }
            beefMeat1.PriceAfterSpice();
            if (checkBox1.Checked)
            {
                beefMeat1.MinceSelected();
            }            
            Close();
        }
        private void BeefSpicesForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
