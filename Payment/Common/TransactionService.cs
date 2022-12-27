using System.Data;

namespace Payment.Common;

class TransactionService
{
    private readonly IDbConnection _connection;

    public TransactionService(IDbConnection connection)
    {
        _connection = connection;
    }

    public IDbTransaction BeginTransaction()
        => _connection.BeginTransaction();
}