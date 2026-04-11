using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOP.Domain.SOLID.DIP;
using OOP.Domain.SOLID.ISP;
using OOP.Domain.SOLID.LSP;
using OOP.Domain.SOLID.OCP;
using OOP.Domain.SOLID.SRP;

namespace OOP.WebAPI.Controllers
{     
    [Route("api/[controller]")]
    [ApiController]
    public class SOLIDController:ControllerBase
    {
        private readonly InvoiceCreate _create;
        private readonly InvoicePrint _print;
        private readonly RazorPayGateway _raz;
        private readonly FixedDiscount _fd;
        private readonly NoDiscount _nd;
        private readonly EaseBuzzGateway _eb;
        private readonly IDIPPaymentGateway _dip;
        public SOLIDController(InvoicePrint p,InvoiceCreate c,RazorPayGateway r, FixedDiscount f, NoDiscount n,
            EaseBuzzGateway ez, IDIPPaymentGateway idp)
        {
            _print = p;
            _create = c;
            _raz = r;
            _fd = f;
            _nd = n;
            _eb = ez;
            _dip = idp;
        }

        [HttpPost("/SRP/CreateInvoice")]
        public IActionResult CreateInvoice()
        {
            var json = new
            {
                Name = "SRP = Single Responsibility Principle",
                Message = "A class should have one reason to change (one responsibility)",
                Eg = "Created Seprate class - Print invoice,Create invoice",
                status = _create.Create()
            };

            return Ok(json);
        }

        [HttpPost("/SRP/PrintInvoice")]
        public IActionResult PrintInvoice()
        {
            var json = new
            {
                Name = "SRP = Single Responsibility Principle",
                Message = "A class should have one reason to change (one responsibility)",
                Eg="Created Seprate class - Print invoice,Create invoice",
                status = _print.Print()
            };
            return Ok(json);
        }

        [HttpPost("/OCP/InitiatePayment")]
        public IActionResult InitiatePayment()
        {
            var json = new
            {
                Name = "OCP = Open/Closed Principle",
                Message = "Open for Extension and Close for modification",
                Eg = "Created interface of IPaymentGateway and RazorPayGateway,EaseBuzz,etc can be extended",
                status = _print.Print()
            };
            return Ok(json);
        }


        [HttpPost("/LSP/Discount")]
        public IActionResult Discount()
        {
            var json = new
            {
                Name = "LSP = Liskov Substitution Principle",
                Message = "Whether you use the parent object or the child object, the program should behave the same way.",
                Eg = "Created interface of IDiscount and FixedDiscount,NoDiscount class will implement interface both behave proper",
                status = _fd.Apply(100)
            };
            return Ok(json);
        }

        [HttpPost("/ISP/EaseBuzz")]
        public IActionResult EaseBuzz()
        {
            var json = new
            {
                Name = "ISP = Interface Segregation Principle",
                Message = "Break large interface into smaller,specifed one. No client should be forced to depend on methods it doesn’t use.",
                Eg = "Created interface of IPayment,IStatus,IRefund if easebuzz wants irefund and ipayment not status",
                status = _eb.Status()
            };
            return Ok(json);
        }

        [HttpPost("/DIP/HDFCSmartGateway")]
        public IActionResult HDFCSmartGateway()
        {
            var json = new
            {
                Name = "DIP = Dependency Inversion Principle",
                Message = "High-level modules should not depend on low-level modules — both should depend on abstraction",
                Eg = "Created interface of IDIPPaymentGateway in controller injected IDIPPaymentGateway so hdfc is directly not access",
                status = _dip.Initiate()
            };
            return Ok(json);
        }

    }

}
