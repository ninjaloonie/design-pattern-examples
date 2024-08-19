namespace FactoryPattern;

public class StudioApartmentFactory : IApartmentFactory
{
    public IApartment Create()
    {
        return new StudioApartment();
    }
}
