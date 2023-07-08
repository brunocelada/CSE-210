public class Food : MenuContainer
{
    private string _food;
    private List<string> _recipe;
    private List<string> _placesToEat;

    Food(string food)
    {
        _food = food;
    }

    public void EditRecipe()
    {
        Console.WriteLine("Add all the steps you need. Write 0 when you're done.");
        string place = Console.ReadLine();
        while (place != "0")
        {
            _placesToEat.Add(place);
            place = Console.ReadLine();
        }
    }
    public void AddPlacesToEat()
    {
        Console.WriteLine("Add all the places you want. Write 0 when you're done.");
        string place = Console.ReadLine();
        while (place != "0")
        {
            _placesToEat.Add(place);
            place = Console.ReadLine();
        }
    }
    public void RemovePlace(int index)
    {
        _placesToEat.RemoveAt(index - 1);
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{_food}:\n >Recipe:");
        DisplayList(_recipe);
        Console.WriteLine(" >Places to eat:");
        DisplayList(_placesToEat);
    }

}