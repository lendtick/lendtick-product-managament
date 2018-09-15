using Lendtick.Product.API.Core.Model.Response;
using Lendtick.Product.Business.Business;
using Lendtick.Product.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.API.Core.Controllers.Category
{
    [Authorize]
    [ApiController]
    [Route("master")]
    public class CategoryController : ControllerBase
    {
        [HttpGet("firstcategory")]
        [Produces("application/json")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CategoryResponse))]
        public async Task<ActionResult<CategoryResponse>> GetFirstCategory()
        {
            IResultStatus result = new ResultStatus();
            CategoryResponse response = new CategoryResponse();

            ICategoryManager manager = new CategoryManager();
            result = await manager.GetFirstCategory();

            response.Status = result.IsSuccess;
            response.Message = result.Message;

            if (!result.IsSuccess)
            {
                return NotFound(response);
            }

            response.Data = manager.Categories as List<string>;

            return Ok(response);
        }
    }
}