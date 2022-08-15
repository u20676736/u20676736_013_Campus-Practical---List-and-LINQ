namespace ProductSupplier.Models
    {

    // Complete this View Model. Consider the data that it would receive and manage.
    // You would also need to use this MODEL to manage the data that is shared 
    // between the Supplier (SupplierID) and the Product (ProductID). Finally this 
    // model should manage the prices obtained from the list.

    public class ProdSupplier  // Complete this model......
    {
        public int ProductID { get; set; }
        public double Price { get; set; }
        public int SupplierID { get; set; }
    }
}