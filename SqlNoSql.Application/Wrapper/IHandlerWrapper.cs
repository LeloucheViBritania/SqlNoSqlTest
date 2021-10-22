using MediatR;
using SqlNoSql.Application.Config;

namespace SqlNoSql.Application.Wrapper
{
    public interface IHandlerWrapper<in TRequest, TResponse> : IRequestHandler<TRequest, Response<TResponse>> 
        where TRequest :IRequestWrapper<TResponse>
    {
    }
}
