using AvaloniaApplicationPracticeOne.Models;
namespace AvaloniaApplicationPracticeOne;

public class Service
{
    private static Gr612RarevContext? _db;

    public static Gr612RarevContext GetDbContext()
    {
        if (_db == null)
        {
            _db = new Gr612RarevContext();
        }

        return _db;
    }
    
}