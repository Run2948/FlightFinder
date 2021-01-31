using System;

namespace FlightFinder.Shared
{
    public enum TicketClass : int
    {
        Economy = 0,
        PremiumEconomy = 1,
        Business = 2,
        First = 3,
    }

    public static class TicketClassExtensions
    {
        public static string ToDisplayString(this TicketClass ticketClass)
        {
            return ticketClass switch
            {
                TicketClass.Economy => "Economy",
                TicketClass.PremiumEconomy => "Premium Economy",
                TicketClass.Business => "Business",
                TicketClass.First => "First",
                _ => throw new ArgumentException("Unknown ticket class: " + ticketClass.ToString())
            };
        }
    }
}
