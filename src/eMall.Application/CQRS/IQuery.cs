using Hommy.ResultModel;
using MediatR;

namespace eMall.Application.CQRS
{
    public interface IQuery<TOut> : IRequest<Result<TOut>>
    {
    }
}