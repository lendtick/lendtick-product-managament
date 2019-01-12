using System.Collections.Generic;

namespace Lendtick.Product.Common.Domain
{
    public class SearchProduct : Search
    {
        public string name { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public List<string> color { get; set; }
    }
}
