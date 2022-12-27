using System.Data;

namespace Payment.Common;

class UnitOfWork : IUnitOfWork
{
    private readonly IDbTransaction _transaction;

    public UnitOfWork(IDbTransaction transaction)
    {
        _transaction = transaction;
    }

    public Task Commit()
    {
        _transaction.Commit();

        return Task.CompletedTask;
    }
}