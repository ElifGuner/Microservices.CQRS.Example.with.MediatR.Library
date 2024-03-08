using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Responses;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request) 
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
