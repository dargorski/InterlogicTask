using System.Web.Mvc;
using InterlogicTask.Models.Pages;
using InterlogicTask.Models.ViewModels.CalculatorPage;

namespace InterlogicTask.Controllers
{
    public class UspCalculationPageController : PageControllerBase<UspCalculationPage>
    {
        public ActionResult Index(UspCalculationPage currentPage)
        {
            var model = new UspCalculationPageModel(currentPage);
            return View(model);
        }        
    }
}