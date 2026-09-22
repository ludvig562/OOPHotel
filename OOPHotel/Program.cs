namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new HotelBooking("Robin", DateTime.Now, 5);
        person1.DisplayBookingInfo();
    }
}
