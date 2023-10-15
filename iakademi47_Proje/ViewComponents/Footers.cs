using Microsoft.AspNetCore.Mvc;
using iakademi47_proje.Models;
using iakademi47_Proje.Models;

namespace iakademi47_Proje.ViewComponents
{
    public class Footers : ViewComponent
    {
        iakademi47Context context = new iakademi47Context();    

        public IViewComponentResult Invoke()
        {
            List<Supplier> suppliers= context.Suppliers.ToList();
            return View(suppliers);

        }



    }
}
