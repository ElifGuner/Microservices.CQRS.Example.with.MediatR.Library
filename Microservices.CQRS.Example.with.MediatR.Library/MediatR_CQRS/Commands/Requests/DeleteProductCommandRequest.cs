using MediatR;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Responses;

namespace Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
    }
}
