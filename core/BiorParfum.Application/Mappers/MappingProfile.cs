using AutoMapper;
using BiorParfum.Application.Dtos;
using BiorParfum.Application.Features.Commands;
using BiorParfum.Domain.Entities.Accounts;
using BiorParfum.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Mappers
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //For User
            CreateMap<CreateUserCommand, User>();
            CreateMap<CreateUserCommand, UserDetail>();


            CreateMap<AddAddressCommand, Address>();


            //For Role
            CreateMap<Role, RoleViewDto>();
            CreateMap<AddRoleCommand, Role>();
            CreateMap<UpdateRoleCommand, Role>();
            CreateMap<DeleteRoleCommand, Role>();

            //For VacancyDetail
            CreateMap<ProductViewDto, Product>();
            CreateMap<Product, ProductViewDto>();
            CreateMap<AddProductsCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<DeleteProductCommand, Product>();

            //For Vacancy
            CreateMap<CategoryViewDto, Category>();
            CreateMap<AddCategoryCommand, Category>();
            CreateMap<DeleteCategoryCommand, Category>();
            CreateMap<Category, CategoryViewDto>();




        }
    }
}
