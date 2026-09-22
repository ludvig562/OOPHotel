namespace OOPHotel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad heter du: ");
        string name = Console.ReadLine();

        int number = 0;
        Console.WriteLine("Hur länge vill du stanna: ");
        Console.WriteLine("Kr/Natt 1500");
        number = ValidInput(number);
        Console.WriteLine("Vilket datum vill du boka? (åååå-mm-dd) ");


        DateTime parsedDate;
        while (!(DateTime.TryParseExact(Console.ReadLine(), "yyyy-mm-dd", null, System.Globalization.DateTimeStyles.None, out parsedDate)) || parsedDate < DateTime.Now)
        {
            Console.WriteLine("Det måste vara ett giltigt datum, försök igen.");
        }


        var person1 = new HotelBooking(name, parsedDate, number);
        Console.WriteLine("\nBokningsinformation:");
        person1.DisplayBookingInfo();

        Console.WriteLine("Välj det nya antalet dagar du vill stanna:");
        number = ValidInput(number);

        person1.UpdateBookingDate(number);
        Console.WriteLine("\nUppdaterad bokningsinformation:");
        person1.DisplayBookingInfo();
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
