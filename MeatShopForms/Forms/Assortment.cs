using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MeatShop;
using System.Linq;


namespace MeatShopForms
{
    public partial class FormAssortment : Form
    {
        database dataBase = new database();
        private List<Meat> meats;
        InterimReport Form3 = null;
        SaleForm Form2 = null;
        public FormAssortment()
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            meats = new List<Meat>();
            LoadMeatFromDB();
            InitializeComponent();

            table_Layout_Assortment.RowCount++;
            table_Layout_Assortment.Controls.Add(new Label() { Text = "Meat type" }, 0, table_Layout_Assortment.RowCount - 1);
            table_Layout_Assortment.Controls.Add(new Label() { Text = "Quantity" }, 1, table_Layout_Assortment.RowCount - 1);
            table_Layout_Assortment.Controls.Add(new Label() { Text = "Price Sell" }, 2, table_Layout_Assortment.RowCount - 1);
            foreach (Meat m in meats)
            {
                table_Layout_Assortment.RowCount++;

                if (m is Beef)
                {
                    table_Layout_Assortment.Controls.Add(new Label { Text = "Beef" }, 0, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.Quantity.ToString(), Name = "BeefQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.PriceSell.ToString(), Name = "BeefPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                }
                else if (m is Pork)
                {
                    table_Layout_Assortment.Controls.Add(new Label { Text = "Pork"}, 0, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.Quantity.ToString(), Name = "PorkQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.PriceSell.ToString(), Name = "PorkPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                }
                else if (m is Chicken)
                {
                    table_Layout_Assortment.Controls.Add(new Label { Text = "Chicken" }, 0, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.Quantity.ToString(), Name = "ChickenQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                    table_Layout_Assortment.Controls.Add(new Label() { Text = m.PriceSell.ToString(), Name = "ChickenPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                }

                
            }
        }
        public  TableLayoutPanel Table_Layout_Assortment
        {
            get { return this.table_Layout_Assortment; }
            set { this.table_Layout_Assortment = value; }
        }
        private double CalculateMonthlyProfit(List<Meat> meats)
        {
            double monthlyProfit = 0;

            foreach (Meat m in meats)
            {
                monthlyProfit += m.Profit;
            }
            return Math.Round(monthlyProfit,2);
        }

        private void LoadMeatFromDB()
        {
            Meat chicken = new Chicken();
            Meat beef = new Beef();
            Meat pork = new Pork();

            if (chicken.DoesMeatExistInDataBase(dataBase))
            {
                chicken.ReadFromBDataBase(dataBase);
                meats.Add(chicken);
            }

           if (beef.DoesMeatExistInDataBase(dataBase))
            {
                beef.ReadFromBDataBase(dataBase);
                meats.Add(beef);
            }

            if (pork.DoesMeatExistInDataBase(dataBase))
            {
                pork.ReadFromBDataBase(dataBase);
                meats.Add(pork);
            }
        }
        private void LoadMeats()
        {
            XmlDocument document = new XmlDocument();
            document.Load("Add_Meat.xml");

            foreach (XmlNode node in document.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                double quantity = double.Parse(node["quantity"].InnerText);
                double priceBuy = double.Parse(node["priceBuy"].InnerText);

                if (name == "chicken")
                {
                    bool chickenAlreadyExists = false;
                    Meat newChicken = new Chicken(quantity, priceBuy);
                   

                    foreach (Meat m in meats)
                    {
                        if (m is Chicken)
                        {
                            m.Add(newChicken);

                            if (!m.DoesMeatExistInDataBase(dataBase))
                            {
                                m.WriteDataBase(dataBase);
                            }
                            else 
                            {
                                m.UpdateDataBase(dataBase);        
                            }

                            chickenAlreadyExists = true;
                            Control[] control = Table_Layout_Assortment.Controls.Find("ChickenQuantity", true);
                            control[0].Text = m.Quantity.ToString();

                            control = Table_Layout_Assortment.Controls.Find("ChickenPriceSell", true);
                            control[0].Text = m.PriceSell.ToString();
                            break;
                        }
                    }
                    if(chickenAlreadyExists == false)
                    {
                        meats.Add(newChicken);

                        newChicken.WriteDataBase(dataBase);

                        table_Layout_Assortment.RowCount++;
                        table_Layout_Assortment.Controls.Add(new Label { Text = "Chicken" }, 0, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newChicken.Quantity.ToString(), Name = "ChickenQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newChicken.PriceSell.ToString(), Name = "ChickenPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                    }
                }
                else if (name == "pork")
                {
                    bool porkAlreadyExists = false;
                    Meat newPork = new Pork(quantity, priceBuy);
                    foreach (Meat m in meats)
                    {
                        if (m is Pork)
                        {
                            m.Add(newPork);

                            if (!m.DoesMeatExistInDataBase(dataBase))
                            {
                                m.WriteDataBase(dataBase);
                            }
                            else
                            {
                                m.UpdateDataBase(dataBase);
                            }

                            porkAlreadyExists = true;
                            Control[] control = Table_Layout_Assortment.Controls.Find("PorkQuantity", true);
                            control[0].Text = m.Quantity.ToString();

                            control = Table_Layout_Assortment.Controls.Find("PorkPriceSell", true);
                            control[0].Text = m.PriceSell.ToString();

                            break;
                        }
                    }
                    if (porkAlreadyExists == false)
                    {
                        meats.Add(newPork);
                        table_Layout_Assortment.RowCount++;
                        table_Layout_Assortment.Controls.Add(new Label { Text = "Pork" }, 0, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newPork.Quantity.ToString(), Name = "PorkQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newPork.PriceSell.ToString(), Name = "PorkPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                    }
                }
                else if (name == "beef")
                {
                    bool beefAlreadyExists = false;
                    Meat newBeef = new Beef(quantity, priceBuy);
                    foreach (Meat m in meats)
                    {
                        if (m is Beef)
                        {
                            m.Add(newBeef);

                            if (!m.DoesMeatExistInDataBase(dataBase))
                            {
                                m.WriteDataBase(dataBase);
                            }
                            else
                            {
                                m.UpdateDataBase(dataBase);
                            }

                            Control[] control = Table_Layout_Assortment.Controls.Find("BeefQuantity", true);
                            control[0].Text = m.Quantity.ToString();

                            control = Table_Layout_Assortment.Controls.Find("BeefPriceSell", true);
                            control[0].Text = m.PriceSell.ToString();
                            beefAlreadyExists = true;
                            break;
                        }
                    }
                    if (beefAlreadyExists == false)
                    {
                        meats.Add(newBeef);
                        table_Layout_Assortment.RowCount++;
                        table_Layout_Assortment.Controls.Add(new Label { Text = "Beef" }, 0, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newBeef.Quantity.ToString(), Name = "BeefQuantity" }, 1, table_Layout_Assortment.RowCount - 1);
                        table_Layout_Assortment.Controls.Add(new Label() { Text = newBeef.PriceSell.ToString(), Name = "BeefPriceSell" }, 2, table_Layout_Assortment.RowCount - 1);
                    }
                }
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            LoadMeats();
        }
        private void ButtonSold_Click(object sender, EventArgs e)
        {
            if (Form2 == null)
            {
                Form2 = new SaleForm(meats, this, dataBase);
                Form2.Closed += Form2_Closed;
                Form2.Show();
            }
        }
        void Form2_Closed(object sender, EventArgs e)
        {
            Form2 = null;
        }

        private void ButtonInterimReport_Click(object sender, EventArgs e)
        {
            if (Form3 == null)
            {
                Form3 = new InterimReport(meats);
                Form3.Closed += Form3_Closed;
                Form3.Show();
            }
        }
        void Form3_Closed(object sender, EventArgs e)
        {
            Form3 = null;
        }
       
        private void MonthlyReport_Click(object sender, EventArgs e)
        {
            StringBuilder reportFileCsv = new StringBuilder();
            DateTime now = DateTime.Now;
            double monthlyProfit = CalculateMonthlyProfit(meats);
            reportFileCsv.AppendLine("Type of meat; Quantity; Profit");

            foreach (Meat m in meats)
            {
                if (m is Chicken)
                {
                    reportFileCsv.AppendLine($"Chicken; {m.SoldMeat.ToString()} kg.; { Math.Round(m.Profit, 2).ToString()} lv.");
                }
                else if (m is Pork)
                {
                    reportFileCsv.AppendLine($"Pork; {m.SoldMeat.ToString()} kg.; { Math.Round(m.Profit, 2).ToString()} lv.");
                }
                else if (m is Beef)
                {
                    reportFileCsv.AppendLine($"Beef; {m.SoldMeat.ToString()} kg.; {Math.Round(m.Profit, 2).ToString()} lv.");
                }
            }
            
            reportFileCsv.AppendLine();
            reportFileCsv.AppendLine($"Monthly profit: {monthlyProfit.ToString()} lv.");

            foreach (Meat m in meats)
            {
                m.SoldMeat = 0;
                m.Profit = 0;
            }

            string csvpath = $"D:\\{now.ToString("MMMMyyyy")}.csv ";

            if (!File.Exists(csvpath))
            {
                File.AppendAllText(csvpath, reportFileCsv.ToString());
                Process.Start(csvpath);
            }
            else
            {
                MessageBox.Show("Report for current month is already created!");
            }
        }

        private void FormAssortment_Load(object sender, EventArgs e)
        {

        }

        private void Table_Layout_Assortment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

