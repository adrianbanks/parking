namespace Parking.Domain
{
    public static class CarParkOutputFormatter
    {
        public static string Format(CarPark carPark)
        {
            return $"""
                    {carPark.Name} is least busy at {carPark.PercentFull}% full.
                    It currently has {carPark.NumberOfFreeSpaces} free spaces.
                    """;
        }
    }
}
