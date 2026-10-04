using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDelivery
{
    public class PriorityInternationalShipment : InternationalShipment
{
        public PriorityInternationalShipment(string trackingCode, string description,
                                         decimal weight, decimal deliveryFee,
                                         string destinationCountry, decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee,
               destinationCountry, customsFee)
        {
        }

    public sealed override void GenerateCustomsReport()
    {
        Console.WriteLine($"Priority Customs Report for {TrackingCode} - fast clearance to {DestinationCountry}");
    }
}
}
