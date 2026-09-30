using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDelivery
{
    public struct Shipment
    {

        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }


        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }


        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)Weight * 5; }
        }



        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50,
                       new DeliveryAddress("Unknown", "Unknown", 0))
        {
        }


        public Shipment(string trackingCode, string description,
                        double weight, decimal deliveryFee,
                        DeliveryAddress destination)
        {

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }

}









