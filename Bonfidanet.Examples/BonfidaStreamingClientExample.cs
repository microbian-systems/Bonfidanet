// unset

using Bonfidanet.Client;
using System;

namespace Bonfidanet.Examples
{
    public class BonfidaStreamingClientExample
    {
        private static readonly IStreamingClient Client = ClientFactory.GetStreamingClient();
        
        static void Example(string[] args)
        {
            Client.SubscribeTrades(trade =>
            {
                Console.WriteLine($"Trade - Market: {trade.Market} Price: {trade.Price} Size: {trade.Size}");
            });

            Console.ReadKey();
            
            Client.UnsubscribeTrades();
        }
    }
}