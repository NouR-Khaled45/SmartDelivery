

namespace SmartDelivery
{
    public class DeliveryCenter
    {
        private const int MaxShipments = 20;

        private readonly Shipment?[] shipments = new Shipment?[MaxShipments];

        public string CenterName { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = string.IsNullOrWhiteSpace(centerName) ? "Unknown" : centerName;
        }
        public Shipment? this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return null;
                return shipments[index];
            }
            set
            {
                if (index < 0 || index >= shipments.Length)
                    return;
                shipments[index] = value;
            }
        }

        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    Shipment? s = shipments[i];
                    if (s != null && s.TrackingCode == trackingCode)
                        return s;
                }
                return null;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                Shipment? s = shipments[i];
                if (s != null && s.TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                Shipment? s = shipments[i];
                if (s == null)
                    continue;
                s.PrintShipment();
                Console.WriteLine();
                Console.WriteLine(new string('-', 40));
                Console.WriteLine();
            }
        }
    }
}