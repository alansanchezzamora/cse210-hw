public class Product{
    private string _productName;
    private string _id;
    private int _price;
    private int _quantity;


    public int priceProduct(){
        return _price * _quantity;
    }
}