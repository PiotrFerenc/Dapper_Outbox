using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Payment.Models;
using Payment.Services;

namespace Payment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPaymentService _paymentService;

    public HomeController(ILogger<HomeController> logger, IPaymentService paymentService)
    {
        _logger = logger;
        _paymentService = paymentService;
    }

    public IActionResult Index()
    {
        _paymentService.MakePayment();
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}