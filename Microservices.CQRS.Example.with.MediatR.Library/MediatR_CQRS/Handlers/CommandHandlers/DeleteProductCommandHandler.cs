using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDBContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);

            if (product != null)
            {
                ApplicationDBContext.ProductList.Remove(product);
            }

            return new DeleteProductCommandResponse()
            {
                IsSuccess = true
            };
        }
    }
}
