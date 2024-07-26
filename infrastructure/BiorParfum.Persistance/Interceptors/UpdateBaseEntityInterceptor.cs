using BiorParfum.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Persistance.Interceptors
{
    public class UpdateBaseEntityInterceptor : SaveChangesInterceptor
    {
        public override ValueTask<int> SavedChangesAsync(SaveChangesCompletedEventData eventData, int result, CancellationToken cancellationToken = default)
        {
            var dbContext = eventData.Context;

            if (dbContext is null)
            {
                return base.SavedChangesAsync(eventData, result, cancellationToken);
            }

            IEnumerable<EntityEntry<BaseEntity>> entries = dbContext
                .ChangeTracker
                .Entries<BaseEntity>();

            foreach (var entityEntry in entries)
            {
                switch (entityEntry.State)
                {
                    case EntityState.Added:
                        entityEntry.Property(x => x.CreatedDate).CurrentValue = DateTime.UtcNow;
                        break;

                    case EntityState.Modified:
                        entityEntry.Property(x => x.UpdatedDate).CurrentValue = DateTime.UtcNow;
                        break;
                }
            }

            return base.SavedChangesAsync(eventData, result, cancellationToken);


        }
    }
}
