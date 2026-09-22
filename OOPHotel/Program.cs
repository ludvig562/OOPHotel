namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new HotelBooking("Robin", "2026-09-22", 5);
        Console.WriteLine(person1.EndDate);
    }
}
