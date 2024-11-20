namespace Tesk1BookingHalls.App;

class Program
{
    static void Main(string[] args)
    {
        var dateRange = new BookingDateRange();

        var range = dateRange.Range();

        Console.WriteLine($"Min: {range.Min}, Max: {range.Max}");
    }
}