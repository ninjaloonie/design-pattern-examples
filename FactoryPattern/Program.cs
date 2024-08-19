namespace FactoryPattern;

public class Program
{
    public static void Main(String[] argv)
    {
        IApartment apartment = new StudioApartmentFactory().Create();

        Console.WriteLine($"Apartment Name: {apartment.GetApartmentName()}");
    }
}