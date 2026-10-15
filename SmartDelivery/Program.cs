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

       // a) Standard shipment
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



        // b) Express shipment
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

        // c) International shipment
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

        // d) Add all shipments to the DeliveryCenter
        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);
        Console.WriteLine("Shipments Added Successfully.");


        // e) Print all shipment details
        Console.WriteLine();
        Console.WriteLine(new string('=', 42));
        Console.WriteLine("Delivery Center");
        Console.WriteLine(new string('=', 42));
        Console.WriteLine();
        center.PrintAllShipments();
        Console.WriteLine(new string('=', 42));

        // f) Tracking status of every shipment
        Console.WriteLine();
        Console.WriteLine("Tracking Status");
        Console.WriteLine();
        center.PrintTrackingStatuses();
        Console.WriteLine(new string('=', 42));

        // g) Insurance cost of every shipment
        Console.WriteLine();
        Console.WriteLine("Insurance");
        Console.WriteLine();
        Console.Write("Standard Shipment Insurance : ");
        DeliveryReport.PrintInsurance(standard);
        Console.Write("Express Shipment Insurance : ");
        DeliveryReport.PrintInsurance(express);
        Console.Write("International Shipment Insurance : ");
        DeliveryReport.PrintInsurance(international);
        Console.WriteLine(new string('=', 42));


        // h) ITrackable[] array
        Console.WriteLine();
        Console.WriteLine("Using ITrackable[]...");
        Console.WriteLine();
        ITrackable[] trackables = { standard, express, international };
        foreach (ITrackable t in trackables)
        {
            DeliveryReport.PrintShipment(t);
        }
        Console.WriteLine(new string('=', 42));


        // i) IInsurable[] array
        Console.WriteLine();
        Console.WriteLine("Using IInsurable[]...");
        Console.WriteLine();
        IInsurable[] insurables = { standard, express, international };
        foreach (IInsurable i in insurables)
        {
            Console.Write("Insurance : ");
            DeliveryReport.PrintInsurance(i);
        }
        Console.WriteLine(new string('=', 42));

        Console.WriteLine();
        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
    }
}