public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public bool CountryUSA(){
        if (_country == "USA"){
            return true;
        } 
        else{
            return false;
        }
    }
    public string DisplayAdress(){
        return ($"{_street} {_city} {_state} {_country}");
    }
}