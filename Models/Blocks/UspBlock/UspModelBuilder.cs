namespace InterlogicTask.Models.Blocks.UspBlock
{
    public class UspModelBuilder
    {
        public UspModel Build(UspPropositionBlock currentBlock)
        {
            return new UspModel
            {
                Title = currentBlock.Title,
                Price = currentBlock.Price,
                PriceDescription = currentBlock.PriceDescription,
                AdditionalDescription = currentBlock.AdditionalDescription,
                ServicesList = currentBlock.ServicesList
            };
        }
    }
}