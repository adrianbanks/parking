namespace Parking.Akka.Ask.ParseCarParksFromData
{
    internal sealed class ParseCarParksFromDataMessage(string data)
    {
        public string Data { get; } = data;
    }
}
