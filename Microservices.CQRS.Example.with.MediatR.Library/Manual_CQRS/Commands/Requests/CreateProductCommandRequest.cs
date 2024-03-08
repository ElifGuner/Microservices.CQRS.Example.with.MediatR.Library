namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Requests
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
