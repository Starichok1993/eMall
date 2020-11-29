using eMall.Application.CQRS;
using eMall.Domain.Entities;
using Hommy.ResultModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace eMall.Application.Features.Products.Queries
{
    public class GetAllProductQuery : IQuery<List<Product>>
    {

    }

    public class GetAllProductQueryHandler : IQueryHandler<GetAllProductQuery, List<Product>>
    {
        private readonly DbContext _dbContext;

        public GetAllProductQueryHandler(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _dbContext.Set<Product>().ToListAsync(cancellationToken: cancellationToken);
            return products;
        }
    }

}
