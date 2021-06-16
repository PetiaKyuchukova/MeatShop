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
    public class Chicken : Meat
    {
        public const double bonedPercentSurcharge = 0.1;
        public Chicken()
        {
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
            this.type = "Chicken";
        }

        public Chicken(double quantity, double priceBuy)
            : base(quantity, priceBuy)
        {
            this.priceSell = priceBuy + (priceBuy * 0.3);
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
            this.type = "Chicken";
        }       
        protected override void FillAvailableSpicesDictionary()
        {
            availableSpicesDictionary = new Dictionary<Spices, double>();
            availableSpicesDictionary.Add(Spices.Salt, 0.01);
            availableSpicesDictionary.Add(Spices.Paprika, 0.01);
            availableSpicesDictionary.Add(Spices.Pepper, 0.01);
            availableSpicesDictionary.Add(Spices.Rosemary, 0.02);
            availableSpicesDictionary.Add(Spices.Curry, 0.03);
            availableSpicesDictionary.Add(Spices.Turmeric, 0.03);
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
                        case Spices.Rosemary:
                            this.RosemarySelected();
                            break;
                        case Spices.Curry:
                            this.CurrySelected();
                            break;
                        case Spices.Turmeric:
                            this.TurmericSelected();
                            break;
                        default:
                            break;
                    }
                }

            }
        }
        private void SaltSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Salt]; 
        }
        private void PaprikaSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Paprika];
        }
        private void PepperSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Pepper];
        }
        private void RosemarySelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Rosemary];
        }
        private void CurrySelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Curry];
        }
        private void TurmericSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Turmeric];
        }
        public void BonedSelected()
        {          
            priceSell += priceSell * bonedPercentSurcharge;
        }
        protected override void CalculatePriceSell(Meat newChicken)
        {
            if (this.priceBuy != newChicken.PriceBuy)
            {
                double newPrice = ((this.priceBuy * this.quantity) + (newChicken.PriceBuy * newChicken.Quantity)) / (this.quantity + newChicken.Quantity);
                priceSell = Math.Round(newPrice + (newPrice * 0.3), 2);
              
            }
            else if(this.priceBuy == newChicken.PriceBuy)
            {
                priceSell = priceBuy + (priceBuy * 0.3);
            }
        }
    }
}
