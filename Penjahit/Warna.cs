using System;
using System.Collections.Generic;
using System.Text;

namespace Penjahit.Models
{
    public abstract class Warna : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Warna()
        {
            this.Price = 0;
            this.Name = "Hitam";
        }

        public string About()
        {
            return $"{this.Name}\t\t\t{this.Price}\n";
        }
    }
}
