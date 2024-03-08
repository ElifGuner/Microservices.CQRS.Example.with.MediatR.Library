using MediatR;
//using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Commands.Requests;
//using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.CommandHandlers;
//using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.QueryHandlers;
//using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Commands.Requests;
using Microservices.CQRS.Example.with.MediatR.Library.MediatR_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.CQRS.Example.with.MediatR.Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Manuel CQRS
        //private CreateProductCommandHandler _createProductCommandHandler;
        //private DeleteProductCommandHandler _deleteProductCommandHandler;
        //private GetAllProductQueryHandler _getAllProductQueryHandler;
        //private GetByIdProductQueryHandler _getByIdProductQueryHandler;

        //public ProductsController(CreateProductCommandHandler createProductCommandHandler,
        //                          DeleteProductCommandHandler deleteProductCommandHandler,
        //                          GetAllProductQueryHandler getAllProductQueryHandler,
        //                          GetByIdProductQueryHandler getByIdProductQueryHandler)
        //{
        //    _createProductCommandHandler = createProductCommandHandler;
        //    _deleteProductCommandHandler = deleteProductCommandHandler;
        //    _getAllProductQueryHandler = getAllProductQueryHandler;
        //    _getByIdProductQueryHandler = getByIdProductQueryHandler;
        //}

        //[HttpGet]
        //public IActionResult Get([FromQuery]GetAllProductQueryRequest request) 
        //{
        //    return Ok(_getAllProductQueryHandler.GetAllProduct(request));
        //}

        //[HttpGet("ProductId}")]
        //public IActionResult Get([FromRoute]GetByIdProductQueryRequest request)
        //{
        //    return Ok(_getByIdProductQueryHandler.GetByIdProduct(request));
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] CreateProductCommandRequest request)
        //{
        //    return Ok(_createProductCommandHandler.CreateProduct(request));
        //}

        //[HttpDelete("{ProductId}")]
        //public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
        //{
        //    return Ok(_deleteProductCommandHandler.DeleteProduct(request));
        //}
        #endregion

        #region MediatR CQRS
        private IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpGet("{ProductId}")]
        public IActionResult Get([FromRoute] GetByIdProductQueryRequest request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductCommandRequest request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpDelete("{ProductId}")]
        public IActionResult Delete([FromRoute] DeleteProductCommandRequest request)
        {
            return Ok(_mediator.Send(request));
        }

        #endregion
    }
}
