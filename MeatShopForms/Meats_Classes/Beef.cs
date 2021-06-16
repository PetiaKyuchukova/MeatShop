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
    public class Beef : Meat
    {
        public const double mincePercentSurcharge = 0.05;
        public Beef()
        {
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
            this.type = "Beef";
        }
        public Beef(double quantity, double priceBuy)
            : base(quantity, priceBuy)
        {
            this.priceSell = priceBuy + (priceBuy * 0.4);
            this.type = "Beef";
            FillAvailableSpicesDictionary();
            selectedSpicesList = new List<Spices>();
        }
        
        protected override void FillAvailableSpicesDictionary()
        {
            availableSpicesDictionary = new Dictionary<Spices, double>();
            availableSpicesDictionary.Add(Spices.Salt, 0.01);
            availableSpicesDictionary.Add(Spices.Paprika, 0.01);
            availableSpicesDictionary.Add(Spices.Pepper, 0.01);
            availableSpicesDictionary.Add(Spices.Oregano, 0.03);
            availableSpicesDictionary.Add(Spices.BayLeaf, 0.03);
            availableSpicesDictionary.Add(Spices.Basil, 0.04);
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
                        case Spices.Oregano:
                            this.OreganoSelected();
                            break;
                        case Spices.BayLeaf:
                            this.BayLeafSelected();
                            break;
                        case Spices.Basil:
                            this.BasilSelected();
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
        private void OreganoSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Oregano];
        }
        private void BayLeafSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.BayLeaf];
        }
        private void BasilSelected()
        {
            priceSell += priceSell * availableSpicesDictionary[Spices.Basil];
        }
        public void MinceSelected()
        {
            priceSell += priceSell * mincePercentSurcharge;
        }
    
        protected override void CalculatePriceSell(Meat newBeef)
        {
            if (this.priceBuy != newBeef.PriceBuy)
            {
                double newPrice = ((this.priceBuy * this.quantity) + (newBeef.PriceBuy * newBeef.Quantity)) / (this.quantity + newBeef.Quantity);
                this.priceSell = Math.Round(newPrice + (newPrice * 0.4), 2);
            }
            else
            {
                this.priceSell = priceBuy + (priceBuy * 0.4);
            }
        }
        
      
    }
}
