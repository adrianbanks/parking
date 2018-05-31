using System.Collections.Generic;
using Enexure.MicroBus;
using Parking.Domain;

namespace Parking.MicroBus.Query.ParseDataFromHtml
{
    internal sealed class ParseDataFromHtmlQuery : IQuery<ParseDataFromHtmlQuery, IEnumerable<CarPark>>
    {
        public string Html { get; }

        public ParseDataFromHtmlQuery(string html)
        {
            Html = html;
        }
    }
}
