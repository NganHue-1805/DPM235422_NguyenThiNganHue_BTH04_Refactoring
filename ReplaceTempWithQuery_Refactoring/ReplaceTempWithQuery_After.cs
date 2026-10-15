using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTempWithQuery_Refactoring
{
    public class Product_After
    {
        private int _quantity = 5;
        private double _itemPrice = 100;

        public double GetPrice()
        {
            // Thay biến tạm bằng việc gọi các Query nhỏ gọn
            return BasePrice() * DiscountFactor();
        }

        // Đã biến đổi thành các Query
        private double BasePrice() => _quantity * _itemPrice;

        private double DiscountFactor() => BasePrice() > 1000 ? 0.95 : 0.98;
    }
}
