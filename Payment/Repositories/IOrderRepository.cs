namespace Payment.Repositories;

public interface IOrderRepository
{
    Task Insert(int price);
}