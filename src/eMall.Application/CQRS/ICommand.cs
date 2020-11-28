using Hommy.ResultModel;
using MediatR;

namespace eMall.Application.CQRS
{
    public interface ICommand<TOut> : IRequest<Result<TOut>>
    {
    }

    public interface ICommand : IRequest<Result>
    {
    }
}