namespace Parking.Domain
{
    public sealed class CarPark(string name, int numberOfFreeSpaces, int percentFull)
    {
        public string Name { get; } = name;
        public int NumberOfFreeSpaces { get; } = numberOfFreeSpaces;
        public int PercentFull { get; } = percentFull;
    }
}
