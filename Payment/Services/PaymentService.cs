using Payment.Common;
using Payment.Repositories;

namespace Payment.Services;

class PaymentService : IPaymentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBankRepository _bankRepository;
    private readonly IOrderRepository _orderRepository;

    public PaymentService(IUnitOfWork unitOfWork, IBankRepository bankRepository, IOrderRepository orderRepository)
    {
        _unitOfWork = unitOfWork;
        _bankRepository = bankRepository;
        _orderRepository = orderRepository;
    }

    public Task MakePayment()
    {
        var random = new Random();
        var id = random.Next();

        _bankRepository.Insert(id);
        _orderRepository.Insert(id);

        _unitOfWork.Commit();

        return Task.CompletedTask;
    }
}