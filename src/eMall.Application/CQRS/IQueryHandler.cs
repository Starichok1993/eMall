using Hommy.ResultModel;
using MediatR;

namespace eMall.Application.CQRS
{
    public interface IQueryHandler<TIn, TOut> : IRequestHandler<TIn, Result<TOut>>
        where TIn : IQuery<TOut>
    {
    }
}