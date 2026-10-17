namespace SmartDelivery
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('=', 42));
        }

        public static void PrintSubSeparator()
        {
            Console.WriteLine(new string('-', 42));
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("Smart Delivery Management System");
            PrintSeparator();
        }

        public static void PrintSection(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }
    }
}