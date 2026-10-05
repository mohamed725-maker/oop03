namespace oop03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q1

            //a) 1- Method Overloading: Same method name with different parameters in the same class
            //   2- Method Overriding: A derived class provides a new body of a method inherited from the base class
            //b) 
            // 1- Static Binding: Early binding The method to be called is determined at compile time
            // 2- Dynamic Binding: Late binding The method to be called is determined at runtime
            #endregion

            #region q2

            //a) The sealed keyword prevents a class from being inherited by another class

            //b)
            //1- Sealed class: Prevents other classes from inheriting from it
            //2- Sealed method: Prevents derived classes from overriding that specific method

            //c) No,becuse sealed keyword Prevents derived classes from overriding that specific method

            #endregion

            #region part02


            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.WriteLine("enter the center name:");
            deliveryCenter.CenterName = Console.ReadLine();

            Console.WriteLine("1-Standard Shipment ");

            Console.WriteLine("tracking code :");
            string trackingCode01 = Console.ReadLine();
            Console.WriteLine("description:");
            string description01 = Console.ReadLine();
            int weight01;
            do
            {
                Console.WriteLine("weight : ");
            }
            while (!int.TryParse(Console.ReadLine(), out weight01));

            decimal deliveryFee01;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee01));

            Console.Write("City: ");

            string city01 = Console.ReadLine();

            Console.Write("Street: ");
            string street01 = Console.ReadLine();

            int buildingNumber01;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber01));

            DeliveryAddress destination01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standardShipment = new StandardShipment(trackingCode01, description01, weight01, deliveryFee01, destination01);

            Console.WriteLine("2-ExpressShipment");

            Console.WriteLine("tracking code :");
            string trackingCode02 = Console.ReadLine();
            Console.WriteLine("description:");
            string description02 = Console.ReadLine();
            int weight02;
            do
            {
                Console.WriteLine("weight : ");
            }
            while (!int.TryParse(Console.ReadLine(), out weight02));

            decimal deliveryFee02;
            do
            {
                Console.WriteLine("delivery fee :");

            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee02));

            Console.Write("City: ");

            string city02 = Console.ReadLine();

            Console.Write("Street: ");
            string street02 = Console.ReadLine();

            int buildingNumber02;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber02));

            DeliveryAddress destination02 = new DeliveryAddress(city02, street02, buildingNumber02);
            decimal extrafee;
            do
            {
                Console.WriteLine("extrafee :");
            } while (!decimal.TryParse(Console.ReadLine(), out extrafee));

            ExpressShipment expressShipment = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02, destination02, extrafee);

            Console.WriteLine("3-InternationalShipment");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine();

            Console.Write("Description: ");
            string description03 = Console.ReadLine();

            int weight03;
            do
            {
                Console.Write("Weight: ");

            }
            while (!int.TryParse(Console.ReadLine(), out weight03));

            decimal deliveryFee03;
            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee03));

            Console.Write("City: ");

            string city03 = Console.ReadLine();

            Console.Write("Street: ");
            string street03 = Console.ReadLine();

            int buildingNumber03;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber03));

            DeliveryAddress destination03 = new DeliveryAddress(city03, street03, buildingNumber03);

            Console.WriteLine("destination country : ");

            string destinationCountry = Console.ReadLine();

            decimal customsfee;
            do
            {
                Console.WriteLine("customerfee :");
            } while (!decimal.TryParse(Console.ReadLine(), out customsfee));

            InternationalShipment internationalShipment = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03, destination03, destinationCountry, customsfee);

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(internationalShipment);
            deliveryCenter.AddShipment(expressShipment);

            deliveryCenter.PrintAllShipments();

            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            standardShipment.weight_update(3);
            standardShipment.weight_update(3, 2);

            internationalShipment.weight_update(3, 2);
            internationalShipment.weight_update(5, 1);

            expressShipment.weight_update(8);
            expressShipment.weight_update(6, 2);

            Shipment[] shipments = { standardShipment, expressShipment, internationalShipment };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }

            // Sealed class:
            // CompletedShipment cannot be inherited.

            // Sealed method:
            // PriorityInternationalShipment.GenerateCustomsReport()
            // is sealed, so it cannot be overridden again.
            #endregion
        }
    }
}