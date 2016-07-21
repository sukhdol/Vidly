using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers
                .Include(c => c.MembershipType)
                .ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel
            {
                Heading = "Add New Customer",
                Action = "Create",
                MembershipTypes = membershipTypes,
                Customer = new Customer()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerFormViewModel formViewModel)
        {
            if (!ModelState.IsValid)
            {
                formViewModel.MembershipTypes = _context.MembershipTypes.ToList();

                return View("CustomerForm", formViewModel);
            }

            _context.Customers.Add(formViewModel.Customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Heading = "Edit Customer",
                Action = "Update",
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(CustomerFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.MembershipTypes = _context.MembershipTypes.ToList();
                return View("CustomerForm", viewModel);
            }

            var customerInDb = _context.Customers.Single(c => c.Id == viewModel.Customer.Id);

            customerInDb.Name = viewModel.Customer.Name;
            customerInDb.Birthdate = viewModel.Customer.Birthdate;
            customerInDb.IsSubscribedToNewsletter = viewModel.Customer.IsSubscribedToNewsletter;
            customerInDb.MembershipTypeId = viewModel.Customer.MembershipTypeId;

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers
                .Include(c => c.MembershipType)
                .SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}