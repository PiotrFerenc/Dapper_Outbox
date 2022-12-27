using System.Data;
using Dapper;

namespace Payment.Repositories;

class BankRepository : IBankRepository
{
    private readonly IDbConnection _connection;
    private readonly IDbTransaction _transaction;

    public BankRepository(IDbConnection connection, IDbTransaction transaction)
    {
        _connection = connection;
        _transaction = transaction;
    }

    public Task Insert(int price)
    {
        _connection.Execute("INSERT INTO Bank VALUES (@Id)", new {Id = price}, _transaction);

        return Task.CompletedTask;
    }
}