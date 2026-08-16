using AssignmentOOP03.Classes;
using AssignmentOOP04.Classes;
using AssignmentOOP04.Interfaces;
using AssignmentOOP04.Struct;

namespace AssignmentOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Question01

            //a)What is Abstraction in Object-Oriented Programming?
            //Hiding implementation details and showing only the essential feature

            //b)Why is abstraction considered one of the four pillars of OOP?
            //1-Reduce complexity
            //2-Improve maintainability
            //3-Enhance security
            //4-Promotes flexibility and reuseability

            #endregion

            #region Part01 Question02

            //a)What is the difference between an Abstract Class and an Interface?
            //Abstract class can have fields, can have constructors and class can inherit from one abstract class
            //Interface can't have fields, can't have constructors and class can implement multiple interfaces

            //b)When would you choose an Interface instead of an Abstract Class?
            //When you don't have fields, require class to support multiple contract

            //c)Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //C# doesn't support multiple inheritance.
            //Class can implement many interfaces because C# suppory multiple implementation

            #endregion

            #region Part02 1-Convert Shipment into an Abstract Class, 2-Create Abstract Members

            //1-Convert Shipment into an Abstract Class
            //2-Create Abstract Members

            #endregion

            #region Part02 3-Update All Shipment Types

            //3-Update All Shipment Types

            //Shipment[] shipments =
            //{
            //    new StandardShipment("lap","Laptop", 20m, 20m, new DeliveryAddress("Cairo","Tahrir",20)),
            //    new ExpressShipment("lap","Laptop", 20m, 20m, new DeliveryAddress("Cairo","Tahrir",20),20m),
            //    new InternationalShipment("lap","Laptop", 20m, 20m, new DeliveryAddress("Cairo","Tahrir",20), "Egypt",30m)
            //};

            //foreach (Shipment shipment in shipments)
            //{
            //    shipment.PrintShipment();
            //    Console.WriteLine(shipment.EstimatedCost);
            //}

            #endregion

            #region Part02 4-Create ITrackable, 4-Create IInsurable

            //4-Create ITrackable 
            //4-Create IInsurable

            #endregion

            #region Part02 6-Create DeliveryReport

            //6-Create DeliveryReport

            #endregion

            #region Part02 7-Update DeliveryCenter

            //7-Update DeliveryCenter

            #endregion

            #region Part02 8-Main() Checklist

            //8-Main() Checklist

            //DeliveryCenter center = new DeliveryCenter("Cairo Center");

            //DeliveryAddress addr01 = new DeliveryAddress("Cairo", "Tahrir", 10);
            //StandardShipment sh01 = new StandardShipment("lap123", "Laptop", 5m, 10.0m, addr01);

            //DeliveryAddress addr02 = new DeliveryAddress("Giza", "Alahram", 20);
            //ExpressShipment sh02 = new ExpressShipment("tele456", "Telephone", 10m, 15.0m, addr02, 5.0m);

            //DeliveryAddress addr03 = new DeliveryAddress("Alex", "Elraml Station", 30);
            //InternationalShipment sh03 = new InternationalShipment("comp789", "Computer", 15m, 20.0m, addr03, "Egypt", 10.0m);

            //center.AddShipment(sh01);
            //center.AddShipment(sh02);
            //center.AddShipment(sh03);

            //center.PrintAllShipments();

            //center.PrintTrackingStatuses();

            //Console.WriteLine("=========================================");
            //Console.WriteLine("Insurance");
            //Console.WriteLine("=========================================");
            //DeliveryReport report = new DeliveryReport();
            //Console.WriteLine($"Standard Shipment Insurance : {sh01.CalculateInsurance()} EGP");
            //Console.WriteLine($"Express Shipment Insurance : {sh02.CalculateInsurance()} EGP");
            //Console.WriteLine($"International Shipment Insurance : {sh03.CalculateInsurance()} EGP");


            //ITrackable[] trackables = { sh01, sh02, sh03 };
            //foreach (ITrackable trackable in trackables)
            //{
            //    Console.WriteLine(trackable.GetTrackingStatus());
            //}

            //IInsurable[] insurables = { sh01, sh02, sh03 };
            //foreach (IInsurable insurable in insurables)
            //{
            //    Console.WriteLine(insurable.CalculateInsurance());
            //}

            //Console.WriteLine("=========================================");
            //Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            #endregion

        }
    }
}
