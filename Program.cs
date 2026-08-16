using AssignmentOOP03.Classes;
using AssignmentOOP04.Classes;
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
        }
    }
}
