using EPiServer.Core;

namespace InterlogicTask.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
