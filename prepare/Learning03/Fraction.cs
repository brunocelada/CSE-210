public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction ()
    {
        _top = _bottom = 1;
    }
    public Fraction (int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and setters
    public int GetTop(){
        return _top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public void SetTop(int top){
        _top = top;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    // Methods
    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue(){
        return _top / (double)_bottom;
    }
}