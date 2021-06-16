using MeatShopForms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatShop
{
    
    [Table("Meats")]
   
    abstract public class Meat
    {
        [Key]
        public int id { set; get; }
        public Meat()
        {

        }

        public Meat(double quantity, double priceBuy)
        {
            this.quantity = quantity;
            this.PriceBuy = priceBuy;
        }

        protected double quantity;
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        protected double priceBuy; 
        public double PriceBuy
        {
            get { return priceBuy; }
            set { priceBuy = value;}
        }

        protected double priceSell;
        public double PriceSell
        {
            get { return priceSell; }
            set { priceSell = value; }
        }

        protected double soldMeat;
        public double SoldMeat
        {
            get { return soldMeat; }
            set { soldMeat = value; }
        }

        protected double profit;
        public double Profit
        {
            get { return profit; }
            set { profit = value; }
        }

        protected string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        protected Dictionary<Spices, double> availableSpicesDictionary;
        public Dictionary<Spices, double> AvailableSpicesDictionary
        {
            get { return availableSpicesDictionary; }
            set { availableSpicesDictionary = value; }
        }

        protected List<Spices> selectedSpicesList;
        public List<Spices> SelectedSpicesList
        {
            get { return selectedSpicesList; }
            set { selectedSpicesList = value; }
        }

        protected abstract void FillAvailableSpicesDictionary();
        public abstract void PriceAfterSpice();
        protected abstract void CalculatePriceSell(Meat newMeat);

        public void Add(Meat newMeat)
        {
            CalculatePriceSell(newMeat);
            this.quantity += newMeat.Quantity;
            this.PriceBuy = newMeat.PriceBuy;
            
        }
        public void Sell(double sale)
        {
            quantity -= sale;
            soldMeat += sale;
            CalculateProfit();
        }
        private void CalculateProfit()
        {
            profit += (soldMeat * priceSell);
        }
        public bool DoesMeatExistInDataBase(database db)
        {
            var countMeat = (from o in db.Meats
                                .Where(o => o.Type == this.Type)
                                select o).Count();

            if (countMeat == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ReadFromBDataBase(database db)
        {
            Meat result = (from o in db.Meats
                         .Where(o => o.Type == this.Type)
                                       select o).Single();

            this.PriceBuy = result.PriceBuy;
            this.PriceSell = result.PriceSell;
            this.Quantity = result.Quantity;
            this.SoldMeat = result.SoldMeat;
            this.Profit = result.Profit;

        }

        public void UpdateDataBase(database db)
        {
            Meat result = (from p in db.Meats
                              .Where(o => o.Type == this.Type)
                                       select p).Single();

            result.PriceBuy = this.PriceBuy;
            result.PriceSell = this.PriceSell;
            result.Quantity = this.Quantity;
            result.SoldMeat = this.SoldMeat;
            result.Profit = this.Profit;

            db.SaveChanges();
        }
        public void WriteDataBase(database db)
        {
            db.Meats.Add(this);
            db.SaveChanges();
        }

    }
}
