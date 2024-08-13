using FastFoodRestaurant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Service
{
    internal interface IService
    {
        Task<PriceTotal> CalculatePrice();
    }
}
