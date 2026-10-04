

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

            public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50,
                          new DeliveryAddress("Unknown", "Unknown", 0))
            {
            }


            public Shipment(string trackingCode, string description,
                         decimal weight, decimal deliveryFee,
                         DeliveryAddress destination)
            {
                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
                Destination = destination;
            }

            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                    DeliveryFee = newFee;
            }


            protected virtual string TypeName
            {
                get { return "Shipment"; }
            }

            protected virtual void PrintExtraDetails()
            {

            }

            public void PrintShipment()
            {
                Console.WriteLine(TypeName);
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight} KG");
                Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
                PrintExtraDetails();
                Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            }
        }
    }










