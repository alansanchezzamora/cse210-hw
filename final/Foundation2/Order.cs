public class Order{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    
    public double CalculateTotal()
    {
        double TotalPrice = 0;
        foreach(Product prod in _products)
        {
            TotalPrice += prod.priceProduct();
        }
        return TotalPrice;
    }
    public int ShippingFee(){
        if(_customer.GetCountryUSA()){
            return 5;
        }
        else{
            return 35;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach ( Product product in _products)
        {
            packingLabel += $"Porduct Name: {product.GetProductName()}, Product ID: {product.GetProductID()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
       
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().DisplayAdress()}\n";
       
    }

}