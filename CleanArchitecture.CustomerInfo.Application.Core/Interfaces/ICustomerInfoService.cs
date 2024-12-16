using System;
using CleanArchitecture.CustomerInfo.Application.Core.DTOs;

namespace CleanArchitecture.CustomerInfo.Application.Core.Interfaces
{
	public interface ICustomerInfoService
	{
		public Task<CustomerInfoDto> CreateCustomer(CustomerInfoDto customerInfoDto);

		public Task<CustomerInfoDto> UpdateCustomer(CustomerInfoDto customerInfoDto);

		public Task<Guid> DeleteCustomer(Guid id);

		public Task<List<CustomerInfoDto>> GetAllCustomers();

		public Task<CustomerInfoDto> GetCustomerById(Guid id);

    }
}

