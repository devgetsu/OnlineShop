using Discount.Application.Abstractions;
using Discount.Application.UseCases.Commands;
using Discount.Domain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Application.UseCases.Handlers.CommandHandlers
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommand, ResponceModel>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UpdateDiscountCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task<ResponceModel> Handle(UpdateDiscountCommand request, CancellationToken cancellationToken)
        {
            try
            {

            }
        }
    }
}
