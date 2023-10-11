using System.Web.Mvc;
using EPiServer.Web.Mvc;
using InterlogicTask.Models.Blocks.UspBlock;

namespace InterlogicTask.Controllers
{
    public class UspBlockController : BlockController<UspPropositionBlock>
    {
        private readonly UspModelBuilder _uspModelBuilder;

        public UspBlockController(UspModelBuilder uspModelBuilder)
        {
            _uspModelBuilder = uspModelBuilder;
        }

        public override ActionResult Index(UspPropositionBlock currentBlock)
        {
            var model = _uspModelBuilder.Build(currentBlock);

            return PartialView(model);
        }
    }
}