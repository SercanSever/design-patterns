using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void AppllyDiscount()
        {
            model.Discount = model.UnitPrice;
            model.DiscountApplied = false;
        }
        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }
        public override ProductViewModel GetModel()
        {
            return model;
        }

    }
}
