namespace SmartDelivery
{
    public static class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"{shipment.CalculateInsurance():F2} EGP");
        }
    }
}