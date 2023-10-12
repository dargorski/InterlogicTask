using System.Collections.Generic;
using InterlogicTask.Models.Blocks.UspBlock;
using InterlogicTask.Models.Pages;

namespace InterlogicTask.Models.ViewModels.CalculatorPage
{
    public class UspCalculationPageModel : PageViewModel<UspCalculationPage>
    {
        public IEnumerable<UspPropositionBlock> UspPropositionBlocks { get; set; }
        public UspCalculationPageModel(UspCalculationPage currentPage) : base(currentPage)
        {
            
        }
    }
}