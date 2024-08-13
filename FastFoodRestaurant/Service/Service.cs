using FastFoodRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Service
{
    internal class Service : IService
    {
        public async Task<PriceTotal> CalculatePrice()
        {
            return new PriceTotal() { ItemCount = 3, TotalPrice = 250 };     
        }
    }
}
