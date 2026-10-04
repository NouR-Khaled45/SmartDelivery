
namespace SmartDelivery
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description,
                         decimal weight, decimal deliveryFee)
    : base(trackingCode, description, weight, deliveryFee)
        {
        }
    }
}
