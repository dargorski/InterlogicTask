using System.Collections.Generic;
using EPiServer;
using InterlogicTask.Models.Blocks.UspBlock;
using InterlogicTask.Models.Pages;

namespace InterlogicTask.Models.ViewModels.CalculatorPage
{
    public class UspCalculationPageModelBuilder
    {
        private readonly IContentLoader _contentLoader;

        public UspCalculationPageModelBuilder(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public UspCalculationPageModel Build(UspCalculationPage currentPage)
        {
            var model = new UspCalculationPageModel(currentPage);
            model.UspPropositionBlocks = GetUspPropositionBlocks(currentPage);

            return model;
        }

        private IEnumerable<UspPropositionBlock> GetUspPropositionBlocks(UspCalculationPage currentPage)
        {
            var contentAreaItems = currentPage.BottomUspBlocksContentArea.Items;
            var uspBlocks = new List<UspPropositionBlock>();
            foreach (var block in contentAreaItems)
            {
                if (_contentLoader.TryGet<UspPropositionBlock>(block.ContentLink, out var uspBlock))
                {
                    uspBlocks.Add(uspBlock);
                }
            }

            return uspBlocks;
        }
    }
}