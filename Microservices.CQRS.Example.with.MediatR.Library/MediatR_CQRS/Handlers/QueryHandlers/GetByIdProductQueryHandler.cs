using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDBContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);

            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                CreateTime = product.CreateTime,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
