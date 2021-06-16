using MeatShop;
using MeatShopForms.Forms;
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
    public partial class SaleForm : Form
    {
        List<Meat> meats;
        double priceSellSpices;
        double kg;
        double priceSellClear;
        Meat sellingMeat;
        ChickenSpicesForm chickenSpices = null;
        PorkSpicesForm porkSpices = null;
        BeefSpicesForm beefSpices = null;
        FormAssortment assortment = null;
        database dataBase;

        public SaleForm(List<Meat> meats, FormAssortment assortment, database dataBase)
        {      
            this.meats = meats;
            this.assortment = assortment;
            this.dataBase = dataBase;

            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }
      
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKgMeat.Clear();
            totalBox.Clear();

            if (RB_Chicken.Checked == true)
            {
                chickenSpices = new ChickenSpicesForm();
               
                foreach (Meat m in meats)
                {
                    if (m is Chicken)
                    {
                        chickenSpices.AddMeat(m);
                        sellingMeat = m;
                        priceSellClear = m.PriceSell;
                        break;
                    }
                }

                chickenSpices.Show();
            }
            else 
            {
                chickenSpices.Close();
            }
        }
        private void RB_Pork_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKgMeat.Clear();
            totalBox.Clear();

            if (RB_Pork.Checked == true)
            {
                porkSpices = new PorkSpicesForm();
               
                foreach (Meat m in meats)
                {
                    if (m is Pork)
                    {
                        porkSpices.AddMeat(m);
                        sellingMeat = m;
                        priceSellClear = m.PriceSell;
                        break;
                    }
                }
                porkSpices.Show();
            }
            else 
            {
                porkSpices.Close();
            }
        }
        private void RB_Beef_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKgMeat.Clear();
            totalBox.Clear();

            if (RB_Beef.Checked == true)
            {
                beefSpices = new BeefSpicesForm();
            
                foreach (Meat m in meats)
                {
                    if (m is Beef)
                    {
                        beefSpices.AddMeat(m);
                        sellingMeat = m;
                        priceSellClear = m.PriceSell;
                       
                        break;
                    }
                }

                beefSpices.Show();
            }
            else 
            {
                beefSpices.Close();
            }
        }
        public double CalculateTotal(double priceSell, double kg)
        {
            double total = priceSell * kg;
            total = Math.Round(total, 2);

            return total;
        }
        private void TextBoxKgMeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(sellingMeat is null)
                {
                    MessageBox.Show("Please select meat!");
                    return;
                }

                this.priceSellSpices = sellingMeat.PriceSell;
                double entertedDouble = 0;
                bool isDoubleEntered = Double.TryParse(textBoxKgMeat.Text, out entertedDouble);
                double total = 0;

                if (isDoubleEntered)
                {
                    kg = double.Parse(textBoxKgMeat.Text);

                    if (kg <= sellingMeat.Quantity)
                    {
                        total = CalculateTotal(priceSellSpices, kg);
                        totalBox.Text = $"{total.ToString()} lv";
                    }
                    else if(kg > sellingMeat.Quantity)
                    {   MessageBox.Show("Not enough meat available! \nMeat available is " + sellingMeat.Quantity + "kg. \nPlease, try again!");
                        textBoxKgMeat.Text = string.Empty;
                        textBoxKgMeat.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Input is not valid! Please enter number!");
                    textBoxKgMeat.Text = string.Empty;
                    textBoxKgMeat.Focus();
                }
            }
            
        }
        
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            this.priceSellSpices = sellingMeat.PriceSell;
            double entertedDouble;
            bool isDoubleEntered = Double.TryParse(textBoxKgMeat.Text, out entertedDouble);
            double total;
            if (isDoubleEntered)
            {
                kg = entertedDouble;

                if (kg <= sellingMeat.Quantity)
                {
                    total = CalculateTotal(sellingMeat.PriceSell, kg);
                    totalBox.Text = $"{total.ToString()} lv";
                }
                else if (kg > sellingMeat.Quantity)
                {
                    MessageBox.Show("Not enough meat available! \nMeat available is " + sellingMeat.Quantity + "kg. \nPlease, try again!");
                    textBoxKgMeat.Text = string.Empty;
                    textBoxKgMeat.Focus();
                }
            }
            else
            {
                MessageBox.Show("Input is not valid! Please enter number!");
                textBoxKgMeat.Text = string.Empty;
                textBoxKgMeat.Focus();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (Meat m in meats)
            {
                if (sellingMeat == m)
                {                  
                    if (m.Quantity > 0 )
                    {
                        m.Sell(kg);
                    }
                   
                    m.PriceSell = priceSellClear;
                    m.UpdateDataBase(dataBase);

                    if (m is Chicken)
                    {
                        Control [] control = assortment.Table_Layout_Assortment.Controls.Find("ChickenQuantity", true);
                        control[0].Text = m.Quantity.ToString();
                    }
                    else if (m is Pork)
                    {
                        Control[] control = assortment.Table_Layout_Assortment.Controls.Find("PorkQuantity", true);
                        control[0].Text = m.Quantity.ToString();
                    }
                    else if (m is Beef)
                    {
                        Control[] control = assortment.Table_Layout_Assortment.Controls.Find("BeefQuantity", true);
                        control[0].Text = m.Quantity.ToString();
                    }

                    break;
                }
            }
            Close();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void KindOfMeat_Click(object sender, EventArgs e)
        {

        }
    }
}
