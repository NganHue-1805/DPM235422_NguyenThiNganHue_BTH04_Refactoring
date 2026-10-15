using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTempWithQuery_Refactoring
{
    public class Product_Before
    {
        private int _quantity = 5;
        private double _itemPrice = 100;

        public double GetPrice()
        {
            // basePrice là biến tạm
            double basePrice = _quantity * _itemPrice;
            double discountFactor;

            if (basePrice > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }
}
