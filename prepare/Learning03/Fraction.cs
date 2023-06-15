public class Fraction
{
    private int upper_part;
    private int lower_part;

    public Fraction()
    {
        lower_part = 1;
        upper_part = 1;
        
    }
    
    public Fraction(int upper)
    {
        lower_part = 1;
        upper_part = upper;
        
    }

    public Fraction(int upper, int lower)
    {
        lower_part = lower;
        upper_part = upper;
       
    }

    public int GetUpperPart()
    {
        return upper_part;
    }

    public void setUpperPart(int upper)
    {
        upper_part = upper;
    }

    public int GetLowerPart()
    {
        return lower_part;
    }
    
    public void SetLowerPart(int lower)
    {
        lower_part = lower;
    }

    public string GetFractionString()
    {
        string FractionString = $"{upper_part}/{lower_part}";
        return FractionString;
    }

    public double GetDecimalValue()
    {
        double value = (double)upper_part / (double)lower_part;
        return value;
    }
}