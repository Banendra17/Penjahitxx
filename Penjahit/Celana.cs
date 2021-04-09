using System;
using System.Collections.Generic;
using System.Text;

namespace Penjahit.Models
{
    public abstract class Celana
    {
        public double Price { get; set; }

        public List<Warna> Toppings;

        public Celana()
        {
            this.Price = 70000;
            this.Toppings = new List<Warna>();
        }

        public Double GetPrice()
        {

            double totalPrice = this.Price;
    
            foreach (var t in this.Toppings)
            {
                totalPrice += t.Price;
            }
            return totalPrice;
        }

        public void AddTopping(Warna t)
        {
            this.Toppings.Add(t);
        }

        public string GetToppingText()
        {
            string strtop = String.Empty;
            foreach (Warna t in this.Toppings)
            {
                strtop += t.About();
            }
            return strtop;
        }

        public string About()
        {
            string strAbout = "\n===Model Dipilih===\n";
            strAbout += "Item\t\t\tPrice\n";
            strAbout += $"{this.ToString().Replace("ConsoleAppFinalPracticalPractice.Models.IceCream","")}\t{this.Price}\n";
          
            strAbout += this.GetToppingText();
            strAbout += "--------------------\n";

            strAbout += $"total\t{this.GetPrice()}\n";
            return strAbout;
        }
    }
}