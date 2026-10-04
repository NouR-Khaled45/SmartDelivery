
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


        public decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description,
                             decimal weight, decimal deliveryFee,
                               DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }



        protected override string TypeName
        {
            get { return "Express Shipment"; }
        }

        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
        }
    }
}