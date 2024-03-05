using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        protected RepositoryContext _context;
        public UnitOfWork(RepositoryContext context)
        {
            _context = context;
        }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
        public virtual async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }
        public virtual void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }
        public virtual void Rollback()
        {
            _context.Database.RollbackTransaction();
        }
        public virtual void Dispose()
        {
            _context.Database.CurrentTransaction?.Dispose();
        }
    }
}
