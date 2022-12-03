using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>(); //We create an empty list of type PizzaOrders

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

            PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
