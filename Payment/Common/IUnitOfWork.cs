namespace Payment.Common;

public interface IUnitOfWork
{
    Task Commit();
}