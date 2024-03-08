using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request) 
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
