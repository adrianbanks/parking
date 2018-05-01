using System;
using Paramore.Brighter;

namespace Parking.Brighter.Information
{
    internal sealed class InformationCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Url { get; set; }

        public InformationCommand()
        {
            Id = Guid.NewGuid();
        }
    }
}
