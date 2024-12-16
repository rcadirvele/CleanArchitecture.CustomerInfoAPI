using System;
using AutoMapper;
using CleanArchitecture.CustomerInfo.Application.Core.Models;
using CleanArchitecture.CustomerInfo.Application.Core.DTOs;

namespace CleanArchitecture.CustomerInfo.Application.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
            CreateMap<CustomerInfoModel, CustomerInfoDto>().ReverseMap();
        }
	}
}

