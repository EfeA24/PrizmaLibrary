﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Application.Features.Books.Queries.GetAllBooks
{
    public class GetAllBooksQueryRequest : IRequest<List<GetAllBooksQueryResponse>>
    {

    }
}
