using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrizmaLibrary.Application.Interfaces.UnitOfWorks;
using PrizmaLibrary.Domain.Entities;

namespace WebApi.Controllers
{
    //Controllerı test amaçlı oluşturdum daha sonra MediatR kullanacağım

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _unitOfWork.GetReadRepository<Book>().GetAllAsync());
        }
    }
}
