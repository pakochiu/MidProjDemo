using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mist126_27
{
    internal class NewOrder : MainPage
    {
        MidProjectEntities DBContext = new MidProjectEntities();
        public void NewOrderPage()
        {
            byte specialDiscount = 0;
            tOrder o = new tOrder { OrderDate = DateTime.Now, SpecialDiscount = specialDiscount/*,  CustomerID = */};
            //var q = from o in DBContext.Orders
            //        from od in DBContext.OrderDetail
            //        from op in DBContext.OrderPlatform
                    
        }
    }
}
