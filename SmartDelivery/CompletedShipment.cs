namespace SmartDelivery
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description,
                         decimal weight, decimal deliveryFee)
    : base(trackingCode, description, weight, deliveryFee)
        {
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}