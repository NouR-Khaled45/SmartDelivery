namespace SmartDelivery;

internal class Program
{
    static void Main(string[] args)
    {
        // a) Create a Driver
        Console.WriteLine("Enter Driver Name:");
        Driver driver = new Driver(Console.ReadLine()!);

        // b) Create a DeliveryCenter
        Console.WriteLine("Enter Delivery Center Name:");
        DeliveryCenter center = new DeliveryCenter(Console.ReadLine()!);

        // c) Assign the Driver to the DeliveryCenter
        center.AssignedDriver = driver;

        // d) Standard shipment
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

        StandardShipment standard = new StandardShipment(code1, desc1, weight1, fee1);

        // e) Express shipment
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
        Console.Write("Extra Fee: ");
        decimal extraFee = Convert.ToDecimal(Console.ReadLine());

        ExpressShipment express = new ExpressShipment(code2, desc2, weight2, fee2, extraFee);

        // f) International shipment
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
        Console.Write("Destination Country: ");
        string country = Console.ReadLine()!;
        Console.Write("Customs Fee: ");
        decimal customsFee = Convert.ToDecimal(Console.ReadLine());

        InternationalShipment international = new InternationalShipment(
            code3, desc3, weight3, fee3, country, customsFee);

        // g) Add all shipments to the DeliveryCenter
        if (
        center.AddShipment(standard) &&
        center.AddShipment(express) &&
        center.AddShipment(international)
        )
            Console.WriteLine("Shipments Added Successfully.");



        // h) Print all shipments using PrintAllShipments()
        Console.WriteLine();
        Console.WriteLine(new string('=', 42));
        Console.WriteLine("Delivery Center");
        Console.WriteLine(new string('=', 42));
        Console.WriteLine();
        Console.WriteLine($"Driver : {center.AssignedDriver?.Name}");
        Console.WriteLine();
        Console.WriteLine(new string('-', 42));
        Console.WriteLine();
        center.PrintAllShipments();
        Console.WriteLine(new string('=', 42));

        // i) DeliveryHelper for each shipment
        Console.WriteLine();
        Console.WriteLine("Printing Using DeliveryHelper...");
        Console.WriteLine();
        DeliveryHelper.PrintShipmentDetails(standard);
        Console.WriteLine("Standard Shipment Printed Successfully.");
        Console.WriteLine();
        DeliveryHelper.PrintShipmentDetails(express);
        Console.WriteLine("Express Shipment Printed Successfully.");
        Console.WriteLine();
        DeliveryHelper.PrintShipmentDetails(international);
        Console.WriteLine("International Shipment Printed Successfully.");
        Console.WriteLine(new string('=', 42));

        // j) Both versions of UpdateWeight() - values from the user
        //Console.WriteLine();
        //Console.WriteLine("Updating Weight...");
        //Console.WriteLine();
        //Console.WriteLine($"Original Weight : {standard.Weight} KG");

        //Console.Write("Enter New Weight: ");
        //decimal newWeight = Convert.ToDecimal(Console.ReadLine());
        //standard.UpdateWeight(newWeight);
        //Console.WriteLine($"Updated Weight : {standard.Weight} KG");



        // k) Shipment[] with mixed types, printed in a loop
        Console.WriteLine();
        Console.WriteLine("Printing Using Shipment[]...");
        Console.WriteLine();
        Shipment[] shipments = { standard, express, international };
        foreach (Shipment s in shipments)
        {
            s.PrintShipment();
            Console.WriteLine();
        }
        Console.WriteLine(new string('=', 42));

        // l) Sealed class and sealed method

        //Console.WriteLine();
        //CompletedShipment completed = new CompletedShipment("SH004", "Book", 1, 40);
        //if (center.AddShipment(completed))
        //    Console.WriteLine("Completed Shipment Added Successfully.");
        //completed.PrintShipment();

        //Console.WriteLine();
        //PriorityInternationalShipment priority = new PriorityInternationalShipment(
        //    "SH005", "Camera", 2, 150, "France", 80);
        //if (center.AddShipment(priority))
        //    Console.WriteLine("Priority International Shipment Added Successfully.");
        //priority.PrintShipment();
        //priority.GenerateCustomsReport();

    }
}