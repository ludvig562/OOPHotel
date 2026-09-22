namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad heter du: ");
        string name = Console.ReadLine();

        int number = 0;
        Console.WriteLine("Hur länge vill du stanna: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Du får bara skriva i siffor, försök igen");
        }
        Console.WriteLine("Vilket datum vill du boka? (åååå-mm-dd): ");


        DateTime parsedDate;
        while (!(DateTime.TryParseExact(Console.ReadLine(), "yyyy-mm-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate)))
        {
            Console.WriteLine("Det måste vara ett giltigt datum, försök igen.");
        }


        var person1 = new HotelBooking(name, parsedDate, number);
        Console.WriteLine("\nBokningsinformation:");
        person1.DisplayBookingInfo();

        Console.WriteLine("Välj det nya antalet dagar du vill stanna:");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Du får bara skriva i siffor, försök igen");
        }
        person1.UpdateBookingDate(number);
        Console.WriteLine("\nUppdaterad bokningsinformation:");
        person1.DisplayBookingInfo();
    }
}
