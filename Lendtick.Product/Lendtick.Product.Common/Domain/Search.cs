using System;
using System.Collections.Generic;
using System.Text;

namespace Lendtick.Product.Common.Domain
{
    public class Search
    {
        public int page { get; set; }
        public int row { get; set; }
        public string sort_by { get; set; }
        public string search { get; set; }
    }
}
