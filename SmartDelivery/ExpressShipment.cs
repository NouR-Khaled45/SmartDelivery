
namespace SmartDelivery
{

    public class ExpressShipment : Shipment
    {
        private decimal extraFee;


        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }



        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description,
                       decimal weight, decimal deliveryFee, decimal extraFee)
    : base(trackingCode, description, weight, deliveryFee)
        {
            ExtraFee = extraFee;
        }



        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}