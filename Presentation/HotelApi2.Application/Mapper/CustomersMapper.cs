using HotelApi2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi2.Application.Mapper
{
    public class CustomersMapper
    {
        public Customers MapToModel(Customers customersEntity)
        {
            return new Customers
            {
                Id = customersEntity.Id,
                CustomerName = customersEntity.CustomerName,
                CustomerSurname = customersEntity.CustomerSurname,
                CustomerId = customersEntity.CustomerId,
                CustomerPhoneNumber = customersEntity.CustomerPhoneNumber
            };
        }

        public Customers MapToEntity(Customers customers)
        {
            return new Customers
            {
                Id = customers.Id,
                CustomerName = customers.CustomerName,
                CustomerSurname = customers.CustomerSurname,
                CustomerId = customers.CustomerId,
                CustomerPhoneNumber = customers.CustomerPhoneNumber
            };
        }
    }
}
