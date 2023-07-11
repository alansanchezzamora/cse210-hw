public class Product{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity){
        _productName = productName;
        _id = productID;
        _price = price;
        _quantity = quantity;
    }
    public double priceProduct(){
        return _price * _quantity;
    }

    public string GetProductName(){
        return _productName;
    }
    public string GetProductID(){
        return _id;
    }
}