using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hommy.ApiResult;
using eMall.Domain.Entities;
using System.Linq;
using Hommy.ResultModel;

namespace eMall.Web.Controllers
{
    public class AppController : ApiControllerBase
    {
        private readonly DbContext _dbContext;

        public AppController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("ping")]
        public async Task<ApiResult> Ping()
        {
            var dbVersion = await _dbContext.Set<DbVersion>().OrderBy(x => x.DateApplied).FirstOrDefaultAsync();

            return Result.Success(dbVersion.Version);
        }
    }
}