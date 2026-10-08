using AspMvcViewComponentsApp.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AspMvcViewComponentsApp.Components
{
    [ViewComponent]
    public class EmployeeInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Employee employee)
        {
            //HtmlContentViewComponentResult viewComponent 
            //    = new(new HtmlString($"<h3>Name</h3><h2>{employee.Name}</h2>"));
            //return viewComponent;
            return View(employee);
        }

    }
}
