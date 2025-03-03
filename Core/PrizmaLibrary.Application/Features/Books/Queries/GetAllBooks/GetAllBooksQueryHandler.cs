using MediatR;
using PrizmaLibrary.Application.Interfaces.UnitOfWorks;
using PrizmaLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQueryRequest, List<GetAllBooksQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetAllBooksQueryResponse>> Handle(GetAllBooksQueryRequest request, CancellationToken cancellationToken)
        {
            var books = await _unitOfWork.GetReadRepository<Book>().GetAllAsync();

            List<GetAllBooksQueryResponse> response = new();

            foreach (var book in books)
            {
                new GetAllBooksQueryResponse()
                {
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    Price = book.Price
                };
            }

            return response;

        }
    }
}
