using System.Numerics;
using System.Timers;
using System.Xml.Linq;

namespace assignment___oop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 
            /*
            ///A-What is the difference between Method Overloading and Method Overriding?
        Overloading: Same method name with different parameters.
        Overriding: Child class redefines a parent class method


            ///B-What is the difference between Static Binding and Dynamic Binding?
          Static Binding: Method is determined at compile time.
          Dynamic Binding: Method is determined at runtime.
              */

            #endregion

            #region Q1 part 2
            

class Shipment
        {
            public string TrackingCode;
            public string Description;
            public double Weight;
            public double DeliveryFee;
            public Shipment(string trackingCode, string description,
                            double weight, double deliveryFee)
            {
                TrackingCode = trackingCode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryFee;
            }

            public virtual double EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5);
                }
            }

            public virtual void PrintShipment()
            {
                Console.WriteLine("Tracking Code : " + trackingCode);
                Console.WriteLine("Description   : " + Description);
                Console.WriteLine("weight      : " + weight + " KG");
                Console.WriteLine("Delivery Fee  : " + deliveryFee + " egp");
                Console.WriteLine("Estimated Cost: " + estimatedCost + " egp");
            }

           
            public void UpdateWeight(double newWeight)
            {
                Weight = newWeight;
            }

          
            public void UpdateWeight(double newWeight, double packingWeight)
            {
                Weight = newWeight + packingWeight;
            }
        }



            #endregion


















    }
    }
}
