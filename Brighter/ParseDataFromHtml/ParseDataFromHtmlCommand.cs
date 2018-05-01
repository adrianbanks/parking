using System;
using System.Collections.Generic;
using Paramore.Brighter;
using Parking.Domain;

namespace Parking.Brighter.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Html { get; }
        public IEnumerable<CarPark> CarParks { get; set; }

        public ParseDataFromHtmlCommand(string html)
        {
            Id = Guid.NewGuid();
            Html = html;
        }
    }
}
