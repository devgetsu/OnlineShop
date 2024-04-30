using Catalog.Application.UseCases.ProductCatalogs.Commands;
using Catalog.Application.UseCases.ProductCatalogs.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatalogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductCatalogController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCatalogCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(GetAllProductCatalogsQuery query)
        {
            var res = await _mediator.Send(query);
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var res = await _mediator.Send(new GetProductCatalogByIdQuery()
            {
                Id = id
            });
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var res = await _mediator.Send(new DeleteProductCatalogCommand()
            {
                Id = id
            });
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCatalogCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

    }
}
