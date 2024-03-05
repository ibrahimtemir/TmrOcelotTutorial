namespace CustomerApi.Base
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync();
        void CommitTransaction();
        void Rollback();
    }
}
