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
        }
    }
}
