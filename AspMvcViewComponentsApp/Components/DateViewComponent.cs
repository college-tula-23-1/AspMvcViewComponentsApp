using Microsoft.AspNetCore.Mvc;

namespace AspMvcViewComponentsApp.Components
{
    [ViewComponent]
    public class DateViewComponent : ViewComponent
    {
        public string Invoke(bool isLong)
        {
            if (!isLong)
                return $"Current Date: {DateTime.Now.ToShortDateString()}";
            else
                return $"Current Date: {DateTime.Now.ToLongDateString()}";
        }
    }
}
