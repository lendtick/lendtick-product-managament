namespace Lendtick.Product.API.Core.Model.Response
{
    public class AuthCheckResponse : BaseSingleResponse<AuthCheck>
    {
        public AuthCheckResponse()
        {
            this.Data = new AuthCheck();
        }
    }

    public class AuthCheck
    {
        public long? id_user { get; set; }
        public string id_role_master { get; set; }
        public string username { get; set; }
    }
}