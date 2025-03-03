using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrizmaLibrary.Application.Features.Books.Queries.GetAllBooks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var response = await _mediator.Send(new GetAllBooksQueryRequest());
            return Ok(response);
        }
    }
}
