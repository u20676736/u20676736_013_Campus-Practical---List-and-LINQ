using System.Collections.Generic;

namespace ProductSupplier.Models
    {

    // Complete this Model. Consider the data that it would receive and manage.
    // You would also need to use this model to manage the data associated with
    // the products (ProductID), the Product's Name, as well as associate it with 
    // the ProdSupplier list.

    public class Product  // Complete this model......
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public List<ProdSupplier> Prices { get; set; }
    }
}