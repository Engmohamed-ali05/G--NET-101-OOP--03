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

        #region Q2 part 2
        /*
        class StandardShipment : Shipment
        {
            public StandardShipment(
                string trackingCode,
                string description,
                double weight,
                double deliveryFee)
                : base(trackingCode, description, weight, deliveryFee)
            {
            }
        }


        class ExpressShipment : Shipment
        {
            public double ExtraFee;

            public ExpressShipment(
                string trackingCode,
                string description,
                double weight,
                double deliveryFee,
                double extraFee)
                : base(trackingCode, description, weight, deliveryFee)
            {
                ExtraFee = extraFee;
            }
        }


        class InternationalShipment : Shipment
        {
            public string DestinationCountry;
            public double CustomsFee;

            public InternationalShipment(
                string trackingCode,
                string description,
                double weight,
                double deliveryFee,
                string destinationCountry,
                double customsFee)
                : base(trackingCode, description, weight, deliveryFee)
            {
                DestinationCountry = destinationCountry;
                CustomsFee = customsFee;
            }
        }

        */

        #endregion

        #region Q3 part 2
        /*  class StandardShipment : Shipment
          {
              public StandardShipment(
                  string trackingCode,
                  string description,
                  double weight,
                  double deliveryFee)
                  : base(trackingCode, description, weight, deliveryFee)
              {
              }


          }


          class ExpressShipment : Shipment
          {
              public double ExtraFee;

              public ExpressShipment(
                  string trackingCode,
                  string description,
                  double weight,
                  double deliveryFee,
                  double extraFee)
                  : base(trackingCode, description, weight, deliveryFee)
              {
                  ExtraFee = extraFee;
              }

              public override double EstimatedCost
              {
                  get
                  {
                      return DeliveryFee + (Weight * 5) + ExtraFee;
                  }
              }
          }


          class InternationalShipment : Shipment
          {
              public string DestinationCountry;
              public double CustomsFee;

              public InternationalShipment(
                  string trackingCode,
                  string description,
                  double weight,
                  double deliveryFee,
                  string destinationCountry,
                  double customsFee)
                  : base(trackingCode, description, weight, deliveryFee)
              {
                  DestinationCountry = destinationCountry;
                  CustomsFee = customsFee;
              }

              public override double EstimatedCost
              {
                  get
                  {
                      return DeliveryFee + (Weight * 5) + CustomsFee;
                  }
              }
          }


          */
        #endregion
        #region Q4 part 2
        /*
                class StandardShipment : Shipment
                {
                    public StandardShipment(
                        string trackingCode,
                        string description,
                        double weight,
                        double deliveryFee)
                        : base(trackingCode, description, weight, deliveryFee)
                    {
                    }

                    public override void PrintShipment()
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Standard Shipment");
                        Console.WriteLine();

                        Console.WriteLine("Tracking Code : " + TrackingCode);
                        Console.WriteLine("Description   : " + Description);
                        Console.WriteLine("Weight        : " + Weight + " KG");
                        Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
                        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
                    }
                }


                class ExpressShipment : Shipment
                {
                    public double ExtraFee;

                    public ExpressShipment(
                        string trackingCode,
                        string description,
                        double weight,
                        double deliveryFee,
                        double extraFee)
                        : base(trackingCode, description, weight, deliveryFee)
                    {
                        ExtraFee = extraFee;
                    }

                    public override double EstimatedCost
                    {
                        get
                        {
                            return DeliveryFee + (Weight * 5) + ExtraFee;
                        }
                    }

                    public override void PrintShipment()
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Express Shipment");
                        Console.WriteLine();

                        Console.WriteLine("Tracking Code : " + TrackingCode);
                        Console.WriteLine("Description   : " + Description);
                        Console.WriteLine("Weight        : " + Weight + " KG");
                        Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
                        Console.WriteLine("Extra Fee     : " + ExtraFee + " EGP");
                        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
                    }
                }


                class InternationalShipment : Shipment
                {
                    public string DestinationCountry;
                    public double CustomsFee;

                    public InternationalShipment(
                        string trackingCode,
                        string description,
                        double weight,
                        double deliveryFee,
                        string destinationCountry,
                        double customsFee)
                        : base(trackingCode, description, weight, deliveryFee)
                    {
                        DestinationCountry = destinationCountry;
                        CustomsFee = customsFee;
                    }

                    public override double EstimatedCost
                    {
                        get
                        {
                            return DeliveryFee + (Weight * 5) + CustomsFee;
                        }
                    }

                    public override void PrintShipment()
                    {

                        Console.WriteLine("International Shipment");
                        Console.WriteLine();

                        Console.WriteLine("Tracking Code : " + Description);
                        Console.WriteLine("Weight  : " + Weight + " KG");
                        Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
                        Console.WriteLine("Destination Country  : " + DestinationCountry);
                        Console.WriteLine("Customs Fee    : " + CustomsFee + " EGP");
                        Console.WriteLine("Estimated Cost  : " + EstimatedCost + " EGP");
                    }
                }

                */
        #endregion
        #region Q5 part 2
        /*
        class DeliveryCenter
        {
            private Shipment[] shipments = new Shipment[10];
            private int count = 0;

            public void AddShipment(Shipment shipment)
            {
                if (count < shipments.Length)
                {
                    shipments[count] = shipment;
                    count++;
                }
            }

            public void RemoveShipment(int index)
            {
                if (index >= 0 && index < count)
                {
                    for (int i = index; i < count - 1; i++)
                    {
                        shipments[i] = shipments[i + 1];
                    }

                    shipments[count - 1] = null;
                    count--;
                }
            }

           
            public Shipment this[int index]
            {
                get
                {
                    return shipments[index];
                }

                set
                {
                    shipments[index] = value;
                }
            }

            public void PrintAllShipments()
            {
                for (int i = 0; i < count; i++)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();
                }
            }
        }


        */
        #endregion

        #region Q6 part 2
        /*
        static class DeliveryHelper
        {
            public static void PrintShipmentDetails(Shipment shipment)
            {
                shipment.PrintShipment();
            }
        }
        */


        #endregion

        #region Q9 part 2

        internal class Program
        {
            static void Main(string[] args)
            {

class Driver
    {
        public string Name;

        public Driver(string name)
        {
            Name = name;
        }
    }


   
        {
            
            Driver driver = new Driver("Ahmed Mohamed");

            
            DeliveryCenter center = new DeliveryCenter();

          
            StandardShipment standard = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80
            );

            
            ExpressShipment express = new ExpressShipment(
                "SH002",
             
            
            InternationalShipment international = new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                "Germany",
                100
            );

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            
            Console.WriteLine("******************************************");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("*******************************************");

            Console.WriteLine();
            Console.WriteLine("Driver : " + driver.Name);
            Console.WriteLine();

            center.PrintAllShipments();

            
            Console.WriteLine("******************************************");
            Console.WriteLine("Printinguse DeliveryHelper");
            Console.WriteLine("*******************************************");

            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine();

            
            Console.WriteLine("******************************************");
            Console.WriteLine("Updating Weight");
            Console.WriteLine("********************************************");

            Console.WriteLine("Original Weight  " + standard.Weight + " KG");

            standard.UpdateWeight(5);

            Console.WriteLine("Updated Weight " + standard.Weight + " KG");

            
            standard.UpdateWeight(5, 0.5);

            Console.WriteLine(
                "Updated Weight After Packing  "   + standard.Weight + " kg"   );

            
            
            Console.WriteLine("*****************************************");
            Console.WriteLine("Printing Using Shipment");
            Console.WriteLine("******************************************");

            Shipment[] shipments =
            {
            standard,
            express,
            international
        };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine();
            }

            
           
        }
    }


        #endregion

















}
}
}
