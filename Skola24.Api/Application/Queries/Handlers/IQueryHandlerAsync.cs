using System.Threading.Tasks;

namespace Skola24.Api.Application
{
    public interface IQuery<TResult>
    {
    }
    public interface IQueryHandlerAsync<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
