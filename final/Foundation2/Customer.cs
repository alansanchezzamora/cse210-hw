public class Customer{
    private string _customerName;
    private Address _customerAddress;

    
    public Customer(string customerName, Address Address){
        _customerName = customerName;
        _customerAddress = Address;
    }
    public void SetCustomerName(string customer){
        _customerName = customer;
    }

    public bool GetCountryUSA()
    {
        return _customerAddress.GetCountryUSA();
    }
    public string GetCustomerName(){
        return _customerName;
    }
    
    public Address GetCustomerAddress(){
        return _customerAddress;
    }

}