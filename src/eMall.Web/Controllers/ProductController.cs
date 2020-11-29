using eMall.Application.Features.Products.Queries;
using Hommy.ApiResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eMall.Web.Controllers
{
    public class ProductController : ApiControllerBase
    {
        private readonly ISender _sender;

        public ProductController (ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("product")]
        public async Task<ApiResult> GetAll()
        {
            return await _sender.Send(new GetAllProductQuery());
        }

    }
}
