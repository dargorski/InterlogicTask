using System.Web.Mvc;
using EPiServer.Web.Mvc;
using InterlogicTask.Models.Blocks.UspBlock;

namespace InterlogicTask.Controllers
{
    public class OptionUspPropositionBlockController : BlockController<OptionUspPropositionBlock>
    {
        private readonly UspModelBuilder _uspModelBuilder;

        public OptionUspPropositionBlockController(UspModelBuilder uspModelBuilder)
        {
            _uspModelBuilder = uspModelBuilder;
        }

        public override ActionResult Index(OptionUspPropositionBlock currentBlock)
        {
            var model = _uspModelBuilder.Build(currentBlock);

            return PartialView(model);
        }
    }
}