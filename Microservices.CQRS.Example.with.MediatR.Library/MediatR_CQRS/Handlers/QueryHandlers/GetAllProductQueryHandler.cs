using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDBContext.ProductList.Select(p => new GetAllProductQueryResponse
            {
                Id = p.Id,
                Name = p.Name,
                CreateTime = p.CreateTime,
                Price = p.Price,
                Quantity = p.Quantity
            }).ToList();
        }
    }
}
