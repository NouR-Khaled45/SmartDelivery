

namespace SmartDelivery
{
    public struct DeliveryCenter
    {
        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }

      
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return default;
                return shipments[index];
            }
            set
            {
                if (index < 0 || index >= shipments.Length)
                    return;
                shipments[index] = value;
            }
        }

       
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode != null &&
                        shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return default;
            }
        }

       
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)   
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
    }


}

