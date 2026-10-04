
namespace SmartDelivery
{

    public class InternationalShipment : Shipment
    {
        private string destinationCountry = "Unknown";
        private decimal customsFee;


        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }


        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }


        public decimal EstimatedCost
        {
            get { return base.EstimatedCost + CustomsFee; }
        }

        public InternationalShipment(string trackingCode, string description,
                                     decimal weight, decimal deliveryFee,
                                     DeliveryAddress destination,
                                     string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }


        protected override string TypeName
        {
            get { return "International Shipment"; }
        }

        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }
    }
}
