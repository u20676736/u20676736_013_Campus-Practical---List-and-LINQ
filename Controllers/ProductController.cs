using ProductSupplier.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductSupplier.Controllers
    {
    public class ProductController : Controller
        {
        
        // Leave the following as is. Do not change links or related items indicated here. 
        public ActionResult Index()
            {
            return View();
            }
        PriceRangeVM priceRangeVM = new PriceRangeVM();

        // In this section, add the necessary details that would pass the repository to the view associated view.
        // In the associated view, you would then need to complete some lambda statements to select only specific
        // data from the repository. So, for example, do not display all the data from the products or suppliers.
        // You would need a lambda statement that would select only very specific data and then display averages.
        // Go to the associated view to identify what needs to be completed. 

        public ActionResult ProductAverages()
            {
            return View();                                       // Complete this line......
            }

        // In this section add the relevant code that would access the ProdSupplier list ( you would need to update
        // the necessary model) so as to access the products in the repository. You would need a loop to access the
        // process in the product. To do this you would need to add a range to the newly created model. After doing
        // so you would need to create a supplier that would receive the values of the suppliers (from the Supplier
        // model), and the return a temporary view model that would be displayed in the appropriate view. 

        public ActionResult SupplierProductAverage()
            {           
            SupplierVM supplierVM = new SupplierVM();

            supplierVM.Suppliers = ListRepository.Suppliers;
           
            List<ProdSupplier> prodSuppliers = new List<ProdSupplier>();

            foreach (var prop in ListRepository.Products)
            {               
                foreach (var price in prop.Prices)
                {                   
                    prodSuppliers.Add(price);
                }
            }           
            supplierVM.ProdSupplier = prodSuppliers;

            return View(supplierVM);
          
            }

        // Leave the following HTTPGET as is. Do not change links or related items indicated here. 
        [HttpGet]
        public ActionResult PriceRange()
            {
            return View();
        }

        // In this section add the relevant code that would access the PriceRange by means of the MIN and MAX ( you
        // would need to update the necessary model) so as to access the products in the repository. You would
        // need a lambda statement that focusses on the products from the ListRepository.
        //
        // To do this you would need to create a temporary VIEW MODEL that needs to receive data from the PriceRangeVM.
        // After doing so you would need to transfer values from from the correct view as well as the ViewModel.


        [HttpPost] // Edited out to avoid duplication error
        public ActionResult PriceRange(int min, int max)                    
        {
            foreach (Product product in ListRepository.Products)
            {
                if (product.Prices.Where(x => x.Price > min && x.Price < max).Count() > 0)
                {
                    priceRangeVM.Products.Add(product);

                }
            }
            return View("PriceRangeResults", priceRangeVM);
         
            }
    }
    }