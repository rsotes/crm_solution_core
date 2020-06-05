using MediatR;
using Services.DTOs.Customers;
using ServicesDto.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesQuery
{
    public class FindAllCustomer : IRequest<IEnumerable<CustomerResponseDto>>
    {
    }
}
