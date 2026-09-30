namespace SmartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////Part 02 : Practical///////////////
            #region 1
            DeliveryAddress a = new DeliveryAddress("Fayoum", "Gamal street", 10);
            DeliveryAddress b = a;
            Console.WriteLine(a.GetFullAddress());
            Console.WriteLine(b.GetFullAddress());

            b.City = "Cairo";
            b.BuildingNumber = 15;
              
            Console.WriteLine(a.GetFullAddress());
            Console.WriteLine(b.GetFullAddress());

            #endregion


            #region a
            DeliveryCenter center = new DeliveryCenter();
            #endregion


            #region b,c
           
            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine($"Enter Shipment {i} Data");

                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();


                string street = Console.ReadLine();

                Console.Write("Building Number: ");

                int building = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, building);
                Shipment shipment = new Shipment(code, description, weight, fee, address);

                if (center.AddShipment(shipment))
                    Console.WriteLine("Shipment added successfully.");
                else
                    Console.WriteLine("Delivery center is full.");

                Console.WriteLine();
            }
            #endregion

            #region d
            Console.WriteLine("--- All Shipments ---");
            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine();
            }
            #endregion

            #region e, f, g
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = center[searchCode];
            if (found.TrackingCode != null)
                Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            else
                Console.WriteLine("Shipment not found.");

            #endregion

        }
    }
}




