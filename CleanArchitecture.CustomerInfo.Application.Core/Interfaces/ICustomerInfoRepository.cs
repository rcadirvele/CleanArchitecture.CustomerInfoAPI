using System;
using CleanArchitecture.CustomerInfo.Application.Core.DTOs;
using CleanArchitecture.CustomerInfo.Application.Core.Models;

namespace CleanArchitecture.CustomerInfo.Application.Core.Interfaces
{
	public interface ICustomerInfoRepository
	{
		public Task SaveCustomer(CustomerInfoModel customerInfo);

		public Task DeleteCustomer(Guid id);

        public Task<List<CustomerInfoModel>> GetAllCustomers();

        public Task<CustomerInfoModel> GetCustomerById(Guid id);

        public Task<IEnumerable<CustomerInfoModel>> GetCustomerByEmail(string email);


    }
}

