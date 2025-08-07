using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Components
{
    public class Cart:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return Content("This is from <h2>View Component</h2>");
        }
    }
}
