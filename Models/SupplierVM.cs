using System.Collections.Generic;

namespace ProductSupplier.Models
    {

    // Complete this View Model. Consider the data that it would receive and manage.
    // You would also need to use this MODEL to manage the data that is shared 
    // between the zONLY the Supplier (SupplierID) and the Product (ProductID).

    public class SupplierVM  // Complete this model......
        {
        public List<Supplier> Suppliers { get; set; }
   
        public List<ProdSupplier> ProdSupplier { get; set; }
       
        public int ProductID { get; set; }
       
        public int SupplierID { get; set; }

    }
    }