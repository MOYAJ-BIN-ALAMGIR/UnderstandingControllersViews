using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace UnderstandingControllersViews.Components
{
    public class Cart:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return new HtmlContentViewComponentResult(new HtmlString("This is from <h2>View Component</h2>"));
        }
    }
}
