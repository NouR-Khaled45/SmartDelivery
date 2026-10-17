
namespace SmartDelivery
{

    public class ExpressShipment : Shipment , ITrackable, IInsurable
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
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }


        public ExpressShipment(string trackingCode, string description,
                       decimal weight, decimal deliveryFee, decimal extraFee)
    : base(trackingCode, description, weight, deliveryFee)
        {
            ExtraFee = extraFee;
            TrackingStatus = "Out For Delivery";
        }
        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
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