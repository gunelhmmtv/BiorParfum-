using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
        void RollBack();

        TRepository SetRepository<TRepository>();
        TRepository GetRepository<TRepository>() where TRepository : class;


        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IAddressRepository AddressRepository { get; }

        ICardItemRepository CardItemRepository { get; }
        ICountryRepository CountryRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IImageRepository ImageRepository { get; }
        IOrderRepository OrderRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IUserRepository UsersRepository { get; }
        IRoleRepository RoleRepository { get; }
    }
}
