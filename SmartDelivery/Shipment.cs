

namespace SmartDelivery
{



    public abstract partial class Shipment
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
        private static int totalShipmentsCreated;

        static Shipment()
        {
            totalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public static int GetTotalShipmentsCreated()
        {
            return totalShipmentsCreated;
        }
        public DeliveryAddress Destination { get; set; } =

        new DeliveryAddress("Unknown", "Unknown", 0);

        public abstract decimal EstimatedCost { get; }

        protected Shipment(string trackingCode)
    : this(trackingCode, "Unknown", 1, 50)
        {
        }

        protected Shipment(string trackingCode, string description,
                        decimal weight, decimal deliveryFee)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            totalShipmentsCreated++;
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();
            copy.Destination = new DeliveryAddress(
                Destination.City, Destination.Street, Destination.BuildingNumber);
            return copy;
        }

        public Shipment CopyShipment()
        {
            return DeepCopy();
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
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

        public abstract void PrintShipment();
    }
}











