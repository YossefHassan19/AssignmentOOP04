using AssignmentOOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Classes
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance : {shipment.CalculateInsurance()} EGP");
        }
    }
}
