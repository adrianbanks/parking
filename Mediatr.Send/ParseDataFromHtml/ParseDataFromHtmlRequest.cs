using System.Collections.Generic;
using MediatR;
using Parking.Domain;

namespace Parking.Mediatr.Send.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlRequest : IRequest<IEnumerable<CarPark>>
    {
        public string Html { get; }

        public ParseDataFromHtmlRequest(string html)
        {
            Html = html;
        }
    }
}
