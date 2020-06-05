using Infrastructure.Repositories;
using Domain;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.extensions;
using Domain.Orders;
using Services.DTOs.Orders;
using Services.Exceptions;

namespace Services
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;

        private readonly IProductRepository productRepository;

        private readonly ICustomerRepository customerRepository;

        public OrderService(IOrderRepository oRepository, IProductRepository pRepository, ICustomerRepository cRepository)
        {
            orderRepository = oRepository;
            productRepository = pRepository;
            customerRepository = cRepository;
        }

        public async Task Add(AddOrderRequest dto)
        {
            var productIds = dto.Items.Select(x => x.Product.Id).ToArray();
            var products = await productRepository.FindAsync(productIds);
            if (products.Count != productIds.Count()) throw new ProductNotFoundException("One or more products are missed");

            var customer = await customerRepository.FindASync(dto.CustomerId);
            if (customer == null) throw new CustomerNotFoundException("Customer not found");

            orderRepository.Add(new Order(
                customer,
                dto.Items.Select(x =>
                    new OrderItem(
                        null,
                        x.Quantity, products.Where(y => y.Id == y.Id).FirstOrDefault())).ToList()));
        }

        public async Task<OrderResponse> Find(int id)
        {
            return await orderRepository.FindASync(id).ContinueWith(x => x.Result.ToOrderDto());
        }
    }
}
