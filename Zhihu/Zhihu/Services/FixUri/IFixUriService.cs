using System.Collections.Generic;
using Zhihu.Core.Models.Basket;
using Zhihu.Core.Models.Catalog;
using Zhihu.Core.Models.Marketing;

namespace Zhihu.Core.Services.FixUri
{
    public interface IFixUriService
    {
        void FixCatalogItemPictureUri(IEnumerable<CatalogItem> catalogItems);
        void FixBasketItemPictureUri(IEnumerable<BasketItem> basketItems);
        void FixCampaignItemPictureUri(IEnumerable<CampaignItem> campaignItems);
    }
}
