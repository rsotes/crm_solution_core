using System.Collections.Generic;

namespace Services.DTOs.Customers
{
    public class AddCustomerRequestDto
    {
        public string Name { get; set; }

        public List<AddressDto> Addresses { get; set; }

        public PhoneNumberDto Phone { get; set; }
    }
}
