using Domain.Customers;

namespace Services.DTOs.Customers.Extensions
{
    public static class CustomerExtension
    {
        public static CustomerResponseDto ToCustomerDto(this Customer customer)
        {
            return new CustomerResponseDto
            {
                Id = customer.CustomerId,
                Name = customer.Name,
            };
        }
    }
}
