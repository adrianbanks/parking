namespace Parking.Domain
{
    public sealed class CarPark
    {
        public string Name { get; }
        public int NumberOfFreeSpaces { get; }
        public int PercentFull { get; }

        public CarPark(string name, int numberOfFreeSpaces, int percentFull)
        {
            Name = name;
            NumberOfFreeSpaces = numberOfFreeSpaces;
            PercentFull = percentFull;
        }
    }
}
