using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using UnderstandingControllersViews.Models;
using UnderstandingControllersViews.Services;

namespace UnderstandingControllersViews.Components
{
    public class Cart : ViewComponent
    {
        private Coupon coupon;
        public Cart(Coupon coupon)
        {
            this.coupon = coupon;
        }
        public IViewComponentResult Invoke(bool showCart)
        {
            Product[] products;
            if (showCart)
            {
                products = new Product[]
                {
                new Product() { Name = "Women Shoes", Price = 99 },
                new Product() { Name = "Mens Shirts", Price = 59 },
                new Product() { Name = "Children Belts", Price = 19 },
                new Product() { Name = "Girls Socks", Price = 9 }
                };
            }
            else
            {
                products = new Product[] { };
            }

                ViewBag.Coupon = coupon.GetCoupon();
            
            return View(products);

            //return new HtmlContentViewComponentResult(new HtmlString("This is from <h2>View Component</h2>"));
        }
    }
}
