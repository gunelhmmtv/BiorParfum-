using BiorParfum.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.EntityFrameworks.Repositories
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly BiorParfumContext _context;
        private readonly Dictionary<Type, object> _repositories;

        public UnitOfWork(BiorParfumContext context)
        {
            _repositories = new Dictionary<Type, object>();
            _context = context;
            _context.Database.BeginTransactionAsync();

        }

        public IProductRepository ProductRepository => SetRepository<IProductRepository>();

        public IUserRepository UserRepository =>SetRepository<IUserRepository>();

        public ICategoryRepository CategoryRepository => SetRepository<ICategoryRepository>();

        public IAddressRepository AddressRepository => SetRepository<IAddressRepository>();

        public IProductRepository CardItemRepository => SetRepository<IProductRepository>();

        public ICountryRepository CountryRepository => SetRepository<ICountryRepository>();

        public ICustomerRepository CustomerRepository =>SetRepository<ICustomerRepository>();

        public IImageRepository ImageRepository => SetRepository<IImageRepository>();

        public IOrderRepository OrderRepository =>SetRepository<IOrderRepository>();

        public IReviewRepository ReviewRepository => SetRepository<IReviewRepository>();

        public IUserRepository UsersRepository => SetRepository<IUserRepository>();

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
            await _context.Database.CommitTransactionAsync();
        }

        public TRepository GetRepository<TRepository>() where TRepository : class
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public TRepository SetRepository<TRepository>()
        {
            if (_repositories.ContainsKey(typeof(TRepository)))
            {
                return (TRepository)_repositories[typeof(TRepository)];
            }

            var repositoryType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => !x.IsInterface && x.IsClass && x.IsAssignableTo(typeof(TRepository)));

            var repositoryInstance = (TRepository)Activator.CreateInstance(repositoryType, _context);
            _repositories.Add(typeof(TRepository), repositoryInstance);
            return repositoryInstance;
        }
    }
}
