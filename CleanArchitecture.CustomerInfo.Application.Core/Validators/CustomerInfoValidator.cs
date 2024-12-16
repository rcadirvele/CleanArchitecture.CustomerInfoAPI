using System;
using FluentValidation;
using CleanArchitecture.CustomerInfo.Application.Core.DTOs;

namespace CleanArchitecture.CustomerInfo.Application.Core.Validators
{
	public class CustomerInfoValidator : AbstractValidator<CustomerInfoDto>
	{
		public CustomerInfoValidator()
		{
            RuleFor(x => x.Email).EmailAddress( FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);

            RuleFor(x => x.FirstName).NotNull().NotEmpty();

            RuleFor(x => x.LastName).NotNull().NotEmpty();

            RuleFor(x => x.Phone).MinimumLength(10).MaximumLength(10);

            RuleFor(x => x.Postcode).MinimumLength(6).MaximumLength(8);


        }
    }
}

