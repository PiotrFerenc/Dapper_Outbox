using System.Data;

namespace Payment.Common;

class UnitOfWork : IUnitOfWork
{
    private readonly IDbTransaction _transaction;
    private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(IDbTransaction transaction, ILogger<UnitOfWork> logger)
    {
        _transaction = transaction;
        _logger = logger;
    }

    public Task Commit()
    {
        try
        {
            _transaction.Commit();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            
            _transaction.Rollback();
        }

        return Task.CompletedTask;
    }
}