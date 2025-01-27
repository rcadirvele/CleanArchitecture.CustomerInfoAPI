﻿using System;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using CleanArchitecture.CustomerInfo.Application.Core.Services;
using CleanArchitecture.CustomerInfo.Application.Core.Interfaces;

namespace CleanArchitecture.CustomerInfo.Application.Core.DIContainer
{
	public static class ServiceInjection
	{
        public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var awsConfigOptions = configuration.GetAWSOptions();// Add Config options
            services.AddDefaultAWSOptions(awsConfigOptions);

            services.AddAWSService<IAmazonDynamoDB>(); //Add DynmoDb services

            services.AddScoped<IDynamoDBContext, DynamoDBContext>(); //Add DynamoDb Context

            services.AddScoped<ICustomerInfoService, CustomerInfoService>();

            return services;

        }
    }
}

