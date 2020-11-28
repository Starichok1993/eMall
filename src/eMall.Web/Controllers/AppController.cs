using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hommy.ApiResult;
using eMall.Domain.Entities;
using System.Linq;
using Hommy.ResultModel;
using MediatR;
using eMall.Application.Features.App.Queries;

namespace eMall.Web.Controllers
{
    public class AppController : ApiControllerBase
    {
        private readonly ISender _sender;

        public AppController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("ping")]
        public async Task<ApiResult> Ping()
        {
            return await _sender.Send(new PingQuery());
        }
    }
}