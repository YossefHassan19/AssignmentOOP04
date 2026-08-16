using AssignmentOOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Classes
{
    internal class DeliveryCenter
    {

        #region Prop

        public string centerName { get; set; }
        private Shipment[]? shipments;
        private int size;

        #endregion

        #region Validation

        public DeliveryCenter(string CenterName)
        {
            centerName = CenterName;
            shipments = new Shipment[20];
            size = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var shipment in shipments)
                {
                    if (shipment != null && shipment.TrackingCode == trackingCode)
                        return shipment;
                }
                return null;
            }
        }

        #endregion

        #region Methods

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    size++;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    size--;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Delivery Center : {centerName}");
            Console.WriteLine("=========================================\n");

            foreach (var shipment in shipments)
            {
                if (shipment != null)
                {
                    Console.WriteLine("-----------------------------------------");
                    shipment.PrintShipment();
                }
            }
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("=========================================");

            foreach (var shipment in shipments)
            {
                if (shipment is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }
        public void PrintInsuringStatuses()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Insuring Status");
            Console.WriteLine("=========================================");

            foreach (var shipment in shipments)
            {
                if (shipment is IInsurable insurable)
                {
                    Console.WriteLine(insurable.CalculateInsurance());
                }
            }
        }

        #endregion

    }
}
