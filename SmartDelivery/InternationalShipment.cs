
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


        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + CustomsFee; }
        }

        public InternationalShipment(string trackingCode, string description,
                               decimal weight, decimal deliveryFee,
                               string destinationCountry, decimal customsFee)
      : base(trackingCode, description, weight, deliveryFee)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }


        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Description         : {Description}");
            Console.WriteLine($"Weight              : {Weight} KG");
            Console.WriteLine($"Delivery Fee        : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }

       
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {TrackingCode} - Country: {DestinationCountry}, Customs Fee: {CustomsFee} EGP");
        }
    }
}
