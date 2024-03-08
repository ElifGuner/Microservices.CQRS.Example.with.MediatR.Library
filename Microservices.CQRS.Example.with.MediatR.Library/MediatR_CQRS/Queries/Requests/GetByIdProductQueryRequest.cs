using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Responses;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid ProductId { get; set; }
    }
}
