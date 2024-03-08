namespace Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Responses
{
    public class GetByIdProductQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
