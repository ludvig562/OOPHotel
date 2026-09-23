using System;

namespace OOPHotel;

public class HotelBooking
{
    public Person[] Person { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    private int _length;

    public int Length
    {
        get { return _length; }
        set
        {
            if (value > 0)
            {
                _length = value;
            }
            else
            {
                throw new ArgumentException("Numret får inte vara negativt, försök igen");
            }
        }
    }
    public HotelBooking(Person[] guest, DateTime startDate, int lengthOfStayInDays)
    {
        DateTime dateString = startDate;
        Person = guest;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
        _length = lengthOfStayInDays;
    }


    public void DisplayBookingInfo()
    {

        foreach (Person guest in Person)
        {
            Console.WriteLine($"Namn: {guest.Name}");
            Console.WriteLine($"E-post: {guest.Mail}");
            Console.WriteLine($"Telefonnummer: {guest.PhoneNumber}\n");
        }

        Console.WriteLine($"Startdatum: {StartDate:d}");
        Console.WriteLine($"Slutdatum: {EndDate:d}");
        Console.WriteLine($"Ditt pris blir: {CalculateBookingPrice()}\n");

    }

    public int CalculateBookingPrice()
    {
        int hotelPrice = 1500 * _length;
        return hotelPrice;
    }

    public void UpdateBookingDate(int lengthOfStayInDay)
    {
        EndDate = StartDate.AddDays(lengthOfStayInDay);
        _length = lengthOfStayInDay;
    }


}
