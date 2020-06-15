using System.Collections.Generic;

namespace Serwis.Models.Catalog
{
    public class ProductIndexModel
    {
        public IEnumerable<ProductListingModel> Products { set; get; }
    }
}
