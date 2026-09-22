using System;

namespace OOPHotel;

public class HotelBooking
{
    public string GuestName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    private int _Length;

    public HotelBooking(string name, DateTime startDate, int lengthOfStayInDays)
    {
        DateTime dateString = startDate;
        GuestName = name;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
        _Length = lengthOfStayInDays;
    }


    public void DisplayBookingInfo()
    {
        Console.WriteLine($"Gästnamn:{GuestName}");
        Console.WriteLine($"Startdatum:{StartDate:d}");
        Console.WriteLine($"Slutdatum:{EndDate:d}");
        Console.WriteLine($"Ditt pris blir:{CalculateBookingPrice()}");
        
    }

    public int CalculateBookingPrice()
    {
        int hotelPrice = 1500 * _Length;
        return hotelPrice;
    }

    public void UpdateBookingDate(int lengthOfStayInDay)
    {
        EndDate = StartDate.AddDays(lengthOfStayInDay);
        _Length = lengthOfStayInDay;
    }
}
