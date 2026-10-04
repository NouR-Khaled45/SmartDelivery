

namespace SmartDelivery
{



    public class Shipment
    {

        private string trackingCode = "UNKNOWN";
        private string description = "Unknown";
        private decimal weight = 1;
        private decimal deliveryFee = 50;


        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }


        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; } =

        new DeliveryAddress("Unknown", "Unknown", 0);

        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public Shipment(string trackingCode)
    : this(trackingCode, "Unknown", 1, 50)
        {
        }

        public Shipment(string trackingCode, string description,
                        decimal weight, decimal deliveryFee)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            Weight = newWeight + packingWeight;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}











