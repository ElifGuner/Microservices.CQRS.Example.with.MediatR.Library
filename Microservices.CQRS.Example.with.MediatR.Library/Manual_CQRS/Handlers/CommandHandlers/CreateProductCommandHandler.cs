using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request) 
        {
            var id = Guid.NewGuid();
            ApplicationDBContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                CreateTime = DateTime.Now,
                Price = request.Price,
                Quantity = request.Quantity
            });

            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };

        }
    }
}
