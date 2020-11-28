using Hommy.ResultModel;
using MediatR;

namespace eMall.Application.CQRS
{
    public interface ICommandHandler<TIn, TOut> : IRequestHandler<TIn, Result<TOut>>
        where TIn : ICommand<TOut>
    {
    }

    public interface ICommandHandler<TIn> : IRequestHandler<TIn, Result>
        where TIn : ICommand
    {
    }
}