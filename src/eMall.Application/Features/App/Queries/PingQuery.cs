using System.Threading;
using System.Threading.Tasks;
using eMall.Application.CQRS;
using eMall.Domain.Entities;
using Hommy.ResultModel;
using Microsoft.EntityFrameworkCore;

namespace eMall.Application.Features.App.Queries
{
    public class PingQuery : IQuery<string>
    {        
    }

    public class PingQueryHandler : IQueryHandler<PingQuery, string>
    {
        private readonly DbContext _dbContext;

        public PingQueryHandler(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<string>> Handle(PingQuery request, CancellationToken cancellationToken)
        {
            var version = (await _dbContext.Set<DbVersion>().FirstAsync()).Version;

            return version;
        }
    }
}