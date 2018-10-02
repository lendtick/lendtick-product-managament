using Lendtick.Product.API.Core.Model.Request;
using Lendtick.Product.API.Core.Model.Response;
using Lendtick.Product.Business.Business;
using Lendtick.Product.Common;
using Lendtick.Product.Common.Domain;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Lendtick.Product.API.Core.Controllers
{
    [Authorize]
    [ApiController]
    [Route("master")]
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Retrieve all product data
        /// </summary>
        /// <returns></returns>
        [HttpGet("product/all")]
        [Produces("application/json")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(ProductResponse))]
        public async Task<ActionResult<ProductResponse>> GetAllProduct()
        {
            IResultStatus result = new ResultStatus();
            ProductResponse response = new ProductResponse();

            IProductManager manager = new ProductManager();
            result = await manager.RetrieveAllProduct();

            response.Status = result.IsSuccess;
            response.Message = result.Message;

            if (!result.IsSuccess)
            {
                return NotFound(response);
            }

            response.Data = manager.Products.Adapt<List<Model.Response.Product>>();

            return Ok(response);
        }

        /// <summary>
        /// Retrieve product with search criteria and sort capability
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("product")]
        [Produces("application/json")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(ProductResponse))]
        public async Task<ActionResult<ProductResponse>> SearchProduct([FromRoute] BaseSearchRequest request)
        {
            IResultStatus result = new ResultStatus();
            ProductResponse response = new ProductResponse();

            IProductManager manager = new ProductManager(request.search, request.sort_by);
            result = await manager.SearchProduct();

            response.Status = result.IsSuccess;
            response.Message = result.Message;

            if (!result.IsSuccess)
            {
                return NotFound(response);
            }

            response.Data = manager.Products.Adapt<List<Model.Response.Product>>();

            return Ok(response);
        }

        /// <summary>
        /// Add product data returned from channel to party for enrichement
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("party")]
        [Produces("application/json")]
        [ProducesResponseType(503)]
        [ProducesResponseType(200, Type = typeof(BaseListResponse<object>))]
        public async Task<ActionResult<BaseListResponse<object>>> AddToParty([FromBody]PartyRequest request)
        {
            IProductManager manager;
            Party domain = new Party();
            IResultStatus result = new ResultStatus();
            BaseListResponse<object> response = new BaseListResponse<object>();

            domain = request.Adapt<Party>();
            manager = new ProductManager(domain);

            result = await manager.AddToParty();

            if (!result.IsSuccess)
            {
                return StatusCode((int)HttpStatusCode.ServiceUnavailable, response);
            }
            
            return Ok(response);
        }
    }
}