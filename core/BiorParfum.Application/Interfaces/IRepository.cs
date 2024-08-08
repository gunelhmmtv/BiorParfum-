﻿using BiorParfum.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync(bool tracking = true);
        Task<T> GetByIdAsync(int id);
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        Task<List<T>> GetWhere(Expression<Func<T, bool>> expression);
    }
}
