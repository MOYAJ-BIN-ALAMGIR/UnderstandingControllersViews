using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using UnderstandingControllersViews.Models;

namespace UnderstandingControllersViews.Components
{
    public class Cart:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Product[] products = new Product[]
            {
                new Product() { Name = "Women Shoes", Price = 99 },
                new Product() { Name = "Mens Shirts", Price = 59 },
                new Product() { Name = "Children Belts", Price = 19 },
                new Product() { Name = "Girls Socks", Price = 9 }
            };

            return View(products);

            //return new HtmlContentViewComponentResult(new HtmlString("This is from <h2>View Component</h2>"));
        }
    }
}
