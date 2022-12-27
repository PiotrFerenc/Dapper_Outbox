namespace Payment.Repositories;

public interface IBankRepository
{
    Task Insert(int price);
}