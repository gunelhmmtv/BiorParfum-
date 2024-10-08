﻿using BiorParfum.Application.Features.Commands;
using BiorParfum.Application.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application
{
    public static class ServiceRegistrations
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Fixed: added missing semicolon
            

            services.AddScoped(typeof(AbstractValidator<AddAddressCommand>), typeof(AddAddressCommandValidator));
            services.AddScoped(typeof(AbstractValidator<CreateUserCommand>), typeof(CreateUserCommandValidator));

            services.AddScoped(typeof(AbstractValidator<AddRoleCommand>), typeof(AddRoleCommandValidator));
            services.AddScoped(typeof(AbstractValidator<UpdateRoleCommand>), typeof(UpdateRoleCommandValidator));
            services.AddScoped(typeof(AbstractValidator<DeleteRoleCommand>), typeof(DeleteRoleCommandValidator));

            services.AddScoped(typeof(AbstractValidator<AddProductsCommand>), typeof(AddProductCommandValidator));
            services.AddScoped(typeof(AbstractValidator<UpdateProductCommand>), typeof(UpdateProductCommandValidator));
            services.AddScoped(typeof(AbstractValidator<DeleteProductCommand>), typeof(DeleteProductCommandValidator));

            services.AddScoped(typeof(AbstractValidator<AddCategoryCommand>), typeof(AddCategoryCommandValidator));
            services.AddScoped(typeof(AbstractValidator<DeleteCategoryCommand>), typeof(DeleteCategoryCommandValidator));
        }
    }
}
