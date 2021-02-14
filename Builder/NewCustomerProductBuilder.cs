using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void AppllyDiscount()
        {
            model.Discount = model.UnitPrice*(decimal)(0.90);
            model.DiscountApplied = true;
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
