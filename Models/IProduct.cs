namespace AspReglini.Models
{
    public struct ISearchResult
    {
        public int totalCount;
        public int numberOfPages;
        public int resultsPerPage;
        public string currency;
        public string[] availableShipFromCountries;
        public ISearchItem[] items;
    }

    public struct ISearchItem
    {
        public string productId;
        public string title;
        public string imageUrl;
        public int totalOrders;
        public int averageRatings;
        public IPriceValue shippingMinPrice;
        public IPriceValue productMinPrice;
        public ISearchCategories[] refiningSearchCategories;
        public IProductProperty[] refiningAttributes;
    }

    public struct IPriceValue
    {
        public int value;
    }

    public struct IProductPropertyValue
    {
        public string id;
        public string name;
        public string imageUrl;
    }

    public struct IProductProperty
    {
        public string id;
        public string name;
        public IProductPropertyValue? value;
    }

    public struct ISearchCategories
    {
        public string id;
        public string name;
        public bool hasChildCategories;
        public IProductProperty[] childCategories;
    }
}
