namespace SmartDelivery
{
    internal class Program
    {

        ///Theoretical Answers//////////
        #region 1
        //a-->struct is a value type: the data is stored directly in the variable
        ///class is a reference type: the variable holds a reference to an object on the heap
        ///Classes support inheritance and polymorphism; structs do not support inheritance.
        ///b-->support inheritance and polymorphism,
        #endregion
        #region 2
        ///a-->Shipment is the parent 
        ///b-->ExpressShipment
        ///c-->ExpressShipment inherits the members of Shipment>>TrackingCode
        ///d-->makes the code shorter, easier to maintain,
        #endregion
        static void Main(string[] args)
        {
            // 1) Create the center
            Console.WriteLine("Enter Delivery Center Name:");
            DeliveryCenter center = new DeliveryCenter(Console.ReadLine()!);

            // 2) Standard shipment
            Console.WriteLine();
            Console.WriteLine("--- Standard Shipment ---");
            Console.Write("Tracking Code: ");
            string code1 = Console.ReadLine()!;
            Console.Write("Description: ");
            string desc1 = Console.ReadLine()!;
            Console.Write("Weight: ");
            decimal weight1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("City: ");
            string city1 = Console.ReadLine()!;
            Console.Write("Street: ");
            string street1 = Console.ReadLine()!;
            Console.Write("Building Number: ");
            int building1 = Convert.ToInt32(Console.ReadLine());

            StandardShipment standard = new StandardShipment(code1, desc1, weight1, fee1,
                new DeliveryAddress(city1, street1, building1));

            // 3) Express shipment
            Console.WriteLine();
            Console.WriteLine("--- Express Shipment ---");
            Console.Write("Tracking Code: ");
            string code2 = Console.ReadLine()!;
            Console.Write("Description: ");
            string desc2 = Console.ReadLine()!;
            Console.Write("Weight: ");
            decimal weight2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("City: ");
            string city2 = Console.ReadLine()!;
            Console.Write("Street: ");
            string street2 = Console.ReadLine()!;
            Console.Write("Building Number: ");
            int building2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Extra Fee: ");
            decimal extraFee = Convert.ToDecimal(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(code2, desc2, weight2, fee2,
                new DeliveryAddress(city2, street2, building2), extraFee);

            // 4) International shipment
            Console.WriteLine();
            Console.WriteLine("--- International Shipment ---");
            Console.Write("Tracking Code: ");
            string code3 = Console.ReadLine()!;
            Console.Write("Description: ");
            string desc3 = Console.ReadLine()!;
            Console.Write("Weight: ");
            decimal weight3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal fee3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("City: ");
            string city3 = Console.ReadLine()!;
            Console.Write("Street: ");
            string street3 = Console.ReadLine()!;
            Console.Write("Building Number: ");
            int building3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Destination Country: ");
            string country = Console.ReadLine()!;
            Console.Write("Customs Fee: ");
            decimal customsFee = Convert.ToDecimal(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(code3, desc3, weight3, fee3,
                new DeliveryAddress(city3, street3, building3), country, customsFee);

            // 5) Add the shipments to the center
            Console.WriteLine();
            center.AddShipment(standard);
            Console.WriteLine("Shipment Added Successfully.");
            center.AddShipment(express);
            Console.WriteLine("Shipment Added Successfully.");
            center.AddShipment(international);
            Console.WriteLine("Shipment Added Successfully.");

            // 6) Print all shipments
            Console.WriteLine();
            Console.WriteLine(new string('=', 40));
            Console.WriteLine($"Delivery Center : {center.CenterName}");
            Console.WriteLine(new string('=', 40));
            center.PrintAllShipments();

            // 7) Remove one shipment
            Console.WriteLine("Enter Tracking Code to Remove:");
            string removeCode = Console.ReadLine()!;
            Console.WriteLine();
            if (center.RemoveShipment(removeCode))
                Console.WriteLine("Shipment Removed Successfully.");

            // 8) Print the remaining shipments
            Console.WriteLine();
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine();
            center.PrintAllShipments();
        }
    }
}




