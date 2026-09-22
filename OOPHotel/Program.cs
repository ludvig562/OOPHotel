namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new HotelBooking("Robin", "2026-09-22", 5);
        person1.DisplayBookingInfo();
    }
}
