using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
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
