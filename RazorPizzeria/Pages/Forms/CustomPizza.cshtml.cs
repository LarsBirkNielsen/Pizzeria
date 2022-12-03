using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] //We bind our CustomPizzaModel ("pageModel") with our PizzasModel on line 11 so we can create a pizza on our CustomPizza view
        public PizzasModel Pizza { get; set; } //Refering to our Model of type Pizza
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() //We send this onPost function to the checkout page
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice }); //We redirect to CheckoutCheckout and pass in a new Pizza, with the piazza name and price we created here
        }
    }
}
