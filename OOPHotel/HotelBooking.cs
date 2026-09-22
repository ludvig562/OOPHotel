using System;

namespace OOPHotel;

public class HotelBooking
{
    public string GuestName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public HotelBooking(string name, DateTime startDate, int lengthOfStayInDays)
    {
        DateTime dateString = startDate;
        GuestName = name;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }

    public void DisplayBookingInfo()
    {
        Console.WriteLine($"Gästnamn:{GuestName}");
        Console.WriteLine($"Startdatum:{StartDate:d}");
        Console.WriteLine($"Slutdatum:{EndDate:d}");
    }
}
