using System.Collections.Generic;

namespace Lendtick.Product.API.Core.Model.Response
{
    public class BaseSingleResponse<T> where T : class
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public class BaseListResponse<T> where T : class
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}