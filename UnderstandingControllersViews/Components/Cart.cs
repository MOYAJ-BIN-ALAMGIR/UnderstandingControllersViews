using Microsoft.AspNetCore.Mvc;

namespace UnderstandingControllersViews.Components
{
    public class Cart:ViewComponent
    {
        public string Invoke()
        {
            return "This is from View Component";
        }
    }
}
