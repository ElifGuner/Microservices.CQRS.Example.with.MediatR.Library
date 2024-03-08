using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
        {
            return ApplicationDBContext.ProductList.Select(p => new GetAllProductQueryResponse
            {
                Id = p.Id,
                Name = p.Name,
                CreateTime =p.CreateTime,
                Price = p.Price,
                Quantity = p.Quantity
            }).ToList();
        }
    }
}
