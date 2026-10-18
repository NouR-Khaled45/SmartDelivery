namespace SmartDelivery;

internal class Program
{
    static void Main(string[] args)
    {
        DeliveryUtilities.PrintSystemTitle();
        Console.WriteLine();

        
        Console.WriteLine($"Shipments Created So Far : {Shipment.GetTotalShipmentsCreated()}");
        Console.WriteLine();

        // ---------------- Creating Shipments ----------------
        DeliveryUtilities.PrintSection("Creating Shipments...");
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
        Console.WriteLine("Standard Shipment Created");

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
        Console.WriteLine("Express Shipment Created");

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
        Console.WriteLine("International Shipment Created");

        Console.WriteLine();
        Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
        Console.WriteLine();

        DeliveryCenter center = new DeliveryCenter("Cairo Center");
        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);

        // ---------------- Object Copying ----------------
        DeliveryUtilities.PrintSection("Object Copying");
        Console.WriteLine();

        Shipment shipment1 = standard;
        Shipment shipment2 = shipment1;         
        Console.WriteLine($"Original Shipment  : {shipment1.TrackingCode}");
        Console.WriteLine($"Assigned Shipment  : {shipment2.TrackingCode}");
        Console.WriteLine();
        Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipment2)}");

        Shipment actualCopy = shipment1.CopyShipment();   
        Console.WriteLine($"Same Object (CopyShipment) : {ReferenceEquals(shipment1, actualCopy)}");
        Console.WriteLine();

        // ---------------- Shallow Copy ----------------
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine("Shallow Copy");
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine();

        standard.Destination = new DeliveryAddress("Cairo", "Tahrir Street", 15);
        Shipment shallow = standard.ShallowCopy();
        Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
        Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.City}");
        Console.WriteLine();
       
        shallow.Destination.City = "Giza";
        Console.WriteLine();
        Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
        Console.WriteLine($"Copied Shipment Address   : {shallow.Destination.City}");
        Console.WriteLine();
        Console.WriteLine($"Same Shipment Object : {ReferenceEquals(standard, shallow)}");
        Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, shallow.Destination)}");
        Console.WriteLine();

        // ---------------- Deep Copy ----------------
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine("Deep Copy");
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine();

        standard.Destination.City = "Cairo";      
        Shipment deep = standard.DeepCopy();
        Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
        Console.WriteLine($"Copied Shipment Address   : {deep.Destination.City}");
        Console.WriteLine();
       
        deep.Destination.City = "Giza";
        Console.WriteLine();
        Console.WriteLine($"Original Shipment Address : {standard.Destination.City}");
        Console.WriteLine($"Copied Shipment Address   : {deep.Destination.City}");
        Console.WriteLine();
        Console.WriteLine($"Same Shipment Object : {ReferenceEquals(standard, deep)}");
        Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standard.Destination, deep.Destination)}");
        Console.WriteLine();

        // ---------------- Extension Methods ----------------
        DeliveryUtilities.PrintSection("Extension Methods");
        Console.WriteLine();
        Console.WriteLine(standard.GetSummary());
        Console.WriteLine(express.GetSummary());
        Console.WriteLine(international.GetSummary());
        Console.WriteLine();
        Console.WriteLine($"{standard.TrackingCode} Is Delivered : {standard.IsDelivered()}");
        Console.WriteLine($"{international.TrackingCode} Is Delivered : {international.IsDelivered()}");
        Console.WriteLine();

        // ---------------- Tracking Status ----------------
        DeliveryUtilities.PrintSection("Tracking Status");
        Console.WriteLine();
        standard.UpdateTrackingStatus("Out For Delivery");
        Console.WriteLine();

        // ---------------- Static Utilities ----------------
        DeliveryUtilities.PrintSection("Static Utilities");
        Console.WriteLine();
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine("Delivery Center");
        DeliveryUtilities.PrintSubSeparator();
        Console.WriteLine();
        Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
        Console.WriteLine();

        // ---------------- Partial Method ----------------
        DeliveryUtilities.PrintSection("Partial Method");
        Console.WriteLine();
        standard.UpdateTrackingStatus("Delivered");
        Console.WriteLine();

       
        Console.WriteLine();
        center.PrintAllShipments();
        Console.WriteLine("Tracking Status (ITrackable)");
        Console.WriteLine();
        center.PrintTrackingStatuses();
        Console.Write("Standard Shipment Insurance : ");
        DeliveryReport.PrintInsurance(standard);
        Console.Write("Express Shipment Insurance : ");
        DeliveryReport.PrintInsurance(express);
        Console.Write("International Shipment Insurance : ");
        DeliveryReport.PrintInsurance(international);
        Console.WriteLine();

        
    }
}