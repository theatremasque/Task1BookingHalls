namespace Tesk1BookingHalls.App;

public class BookingDateRange
{
    public (DateTime Min, DateTime Max) Range()
    {
        var min = DateTime.Now;
        var max = min.AddDays(329);
        return (min, max);
    }
}