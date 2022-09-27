using Microsoft.AspNetCore.Mvc;
using EAD_project.Models.Interface;
using System.Threading.Tasks;

namespace EAD_project.VieComponent
{
    public class ProductViewComponent : ViewComponent
    {
        //private readonly IProduct _product;
        //public ProductViewComponent(IProduct p)
        //{
        //    _product = p;
        //}
        //public IViewComponentResult Invoke()
        //{
        //    return View();
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
