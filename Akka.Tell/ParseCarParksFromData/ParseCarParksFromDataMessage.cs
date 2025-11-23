namespace Parking.Akka.Tell.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataMessage(string data)
    {
        public string Data { get; } = data;
    }
}
