using EPiServer.Core;

namespace EpiserverSiteTest.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
