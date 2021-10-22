using MediatR;
using SqlNoSql.Application.Config;

namespace SqlNoSql.Application.Wrapper
{
    public interface IRequestWrapper<TResponse> : IRequest<Response<TResponse>>
    {
    }
}
