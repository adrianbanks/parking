using MediatR;

namespace Parking.Mediatr.Publish.SendOutput
{
    public sealed class SendOutputNotification : INotification
    {
        public string Output { get; }

        public SendOutputNotification(string output)
        {
            Output = output;
        }
    }
}
