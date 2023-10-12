using System.Web.Mvc;
using InterlogicTask.Models.Pages;
using InterlogicTask.Models.ViewModels.CalculatorPage;

namespace InterlogicTask.Controllers
{
    public class UspCalculationPageController : PageControllerBase<UspCalculationPage>
    {
        private readonly UspCalculationPageModelBuilder _uspCalculationPageModelBuilder;

        public UspCalculationPageController(UspCalculationPageModelBuilder uspCalculationPageModelBuilder)
        {
            _uspCalculationPageModelBuilder = uspCalculationPageModelBuilder;
        }

        public ActionResult Index(UspCalculationPage currentPage)
        {
            var model = _uspCalculationPageModelBuilder.Build(currentPage);
           
            return View(model);
        }        
    }
}