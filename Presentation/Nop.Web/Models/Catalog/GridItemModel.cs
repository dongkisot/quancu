using System;
using Nop.Web.Framework.Mvc;
using Nop.Web.Models.Media;

namespace Nop.Web.Models.Catalog
{
    public enum GridType
    {
        FeatureProuduct,
        BestsellerProduct,
        HomepageCategory,
        News,
        ImageOnly,
        TextOnly
    }

    public partial class GridItemModel
    {
        public GridItemModel()
        {
            ProductPrice = new ProductPriceModel();
            DefaultPictureModel = new PictureModel();
        }

        public int Id { get; set; }
        public GridType GridType { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string SeName { get; set; }

        //picture
        public PictureModel DefaultPictureModel { get; set; }
        //price
        public ProductPriceModel ProductPrice { get; set; }
        //url
        public Uri RedirectUrl { get; set; }

        #region Nested Classes

        public partial class ProductPriceModel : BaseNopModel
        {
            public string OldPrice { get; set; }
            public string Price { get; set; }

            public bool DisableBuyButton { get; set; }
            public bool DisableWishlistButton { get; set; }

            public bool AvailableForPreOrder { get; set; }

            public bool ForceRedirectionAfterAddingToCart { get; set; }
        }

        #endregion

    }
}