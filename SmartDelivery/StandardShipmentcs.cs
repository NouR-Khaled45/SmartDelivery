
namespace SmartDelivery
{
    public class StandardShipment : Shipment
    {

        public StandardShipment(string trackingCode, string description,
                        decimal weight, decimal deliveryFee)
    : base(trackingCode, description, weight, deliveryFee)
        {
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }


}




