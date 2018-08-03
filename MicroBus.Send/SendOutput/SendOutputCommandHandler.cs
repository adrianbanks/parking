﻿using System;
using System.Threading.Tasks;
using Enexure.MicroBus;

namespace Parking.MicroBus.Send.SendOutput
{
    internal sealed class SendOutputCommandHandler : ICommandHandler<SendOutputCommand>
    {
        public Task Handle(SendOutputCommand command)
        {
            Console.WriteLine(command.Output);
            Environment.Exit(0);
            return Task.CompletedTask;
        }
    }
}
