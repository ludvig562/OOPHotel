using System;

namespace OOPHotel;

public class HotelBooking
{
    public string GuestName { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }

    public HotelBooking(string name, string startDate, int lengthOfStayInDays)
    {
        string dateString = startDate;
        DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
        GuestName = name;
        StartDate = startDate;
        EndDate = parsedDate.AddDays(lengthOfStayInDays).ToShortDateString();

    }

    public void DisplayBookingInfo()
    {
        Console.WriteLine($"Gästnamn:{GuestName}");
        Console.WriteLine($"Startdatum:{StartDate}");
        Console.WriteLine($"Slutdatum:{EndDate}");

    
    
    }
        


}
