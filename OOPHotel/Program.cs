using System.Globalization;
using System.Runtime.CompilerServices;

namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        int numberOfGuests = 0;
        Console.Write("Hur många gäster ska bokningen ha? ");
        numberOfGuests = ValidInput(numberOfGuests);

        Person[] guest = new Person[numberOfGuests];

        for (int i = 0; i < numberOfGuests; i++)
        {
            Console.WriteLine($"\nGäst {i + 1}");

            Console.Write("Namn: ");
            string name = Console.ReadLine();

            Console.Write("E-post: ");
            string email = Console.ReadLine();

            Console.Write("Telefonnummer: ");
            string phone = Console.ReadLine();

            guest[i] = new Person(name, email, phone);
        }

        int number = 0;
        Console.WriteLine("Hur länge vill du stanna");
        Console.WriteLine("Kr/Natt 1500");
        number = ValidInput(number);

        Console.WriteLine("Vilket datum vill du boka? (åååå-mm-dd) ");
        DateTime parsedDate;
        while (!(DateTime.TryParseExact(Console.ReadLine(), "yyyy-mm-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate)) || parsedDate > DateTime.Now)
        {
            Console.WriteLine("Det måste vara ett giltigt datum, försök igen.");
        }

        Console.WriteLine("Vill du boka rummet? (ja/nej)");
        string awnser = Console.ReadLine();

        if (awnser == "ja")
        {
            var booking = new HotelBooking(guest, parsedDate, number);

            Console.WriteLine("\nBokningsinformation:");
            booking.DisplayBookingInfo();

            Console.WriteLine("Vill du ändra din bokning? (ja/nej)");
            string choise = Console.ReadLine();

            if (choise == "ja")
            {
                Console.WriteLine("Välj det nya antalet dagar du vill stanna:");
                number = ValidInput(number);

                booking.UpdateBookingDate(number);
                Console.WriteLine("\nUppdaterad bokningsinformation:");
                booking.DisplayBookingInfo();
            }
        }
        else
        {
            Console.WriteLine("Okej, ingen bokning skapades.");
        }
    }

    static int ValidInput(int number)
    {
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Du får bara skriva i siffor och posetiva tal, försök igen");
        }
        return number;
    }
}
