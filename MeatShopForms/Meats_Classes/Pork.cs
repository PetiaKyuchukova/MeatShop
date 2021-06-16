using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeatShop
{
    [NotMapped]
    public class Pork : Meat
    {
        public const double mincePercentSurcharge = 0.05;
        public Pork()
        {
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
            this.type = "Pork";
        }
        public Pork(double quantity, double priceBuy)
            : base(quantity, priceBuy)
        {

            this.priceSell = priceBuy + (priceBuy * 0.5);
            this.type = "Pork";
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
        }
        protected override void FillAvailableSpicesDictionary()
        {
            availableSpicesDictionary = new Dictionary<Spices, double>();
            availableSpicesDictionary.Add(Spices.Salt, 0.01);
            availableSpicesDictionary.Add(Spices.Paprika, 0.01);
            availableSpicesDictionary.Add(Spices.Pepper, 0.01);
            availableSpicesDictionary.Add(Spices.Thyme, 0.03);
            availableSpicesDictionary.Add(Spices.Savory, 0.03);
            availableSpicesDictionary.Add(Spices.Garlic, 0.04);
        }
        public override void PriceAfterSpice()
        {
            if (this.SelectedSpicesList.Count > 0)
            {
                foreach (Spices s in this.SelectedSpicesList)
                {
                    switch (s)
                    {
                        case Spices.Salt:
                            this.SaltSelected();
                            break;
                        case Spices.Paprika:
                            this.PaprikaSelected();
                            break;
                        case Spices.Pepper:
                            this.PepperSelected();
                            break;
                        case Spices.Thyme:
                            this.ThymeSelected();
                            break;
                        case Spices.Savory:
                            this.SavorySelected();
                            break;
                        case Spices.Garlic:
                            this.GarlicSelected();
                            break;
                        default:
                            break;
                    }
                }

            }
           
        }
        public void SaltSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Salt];
        }
        public void PaprikaSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Paprika];
        }
        public void PepperSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Pepper];
        }
        public void GarlicSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Garlic];
        }
        public void SavorySelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Savory];
        }
        public void ThymeSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Thyme];
        }
        public void MinceSelected()
        {
            priceSell += priceSell * mincePercentSurcharge;
        }

        protected override void CalculatePriceSell(Meat newPork)
        {
            if (this.priceBuy != newPork.PriceBuy)
            {
                double newPrice = ((this.priceBuy * this.quantity) + (newPork.PriceBuy * newPork.Quantity)) / (this.quantity + newPork.Quantity);
                priceSell = Math.Round(newPrice + (newPrice * 0.5), 2);
            }
            else
            {
                priceSell = priceBuy + (priceBuy * 0.5);
            }
        }
    }
}
