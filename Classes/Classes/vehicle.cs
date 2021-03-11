using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public enum VehicleType { Car, Truck, Van, motorcycles, Spaceships, Planes, Boats }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public double Mileage { get; set; }
        public VehicleType TypeofVehicle { get; set; }

        public bool IsRunning { get; private set; }

        public Vehicle() { }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle) //getting the properties for the class Vehicle
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeofVehicle = typeOfVehicle;
        }

        public void TrunOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn vehicle on ");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle");
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }


        public void IndicateRight()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOff();

        }

        public void IndicateLeft()
        {
            RightIndicator.FlashOff();
            LeftIndicator.FlashOn();

        }

        public void  ClearIndicators()
        {
            RightIndicator.FlashOff();
            LeftIndicator.FlashOff();
        }

        public void TurnOnHazards()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOff();
        }



    }
    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void FlashOn() // created property FlashOn
        {
            IsFlashing = true;
        }

        public void FlashOff() // created property Flashoff
        {
            IsFlashing = false;
        }


    }

    public class HazadLights 
    {
        public bool IsHazardLights { get; private set; }//created class

        public void HazadLightson()  //created properties like on or off
        {
            IsHazardLights = true;
        }

        public void HazardLightsoff()
        {
            IsHazardLights = false;
        }
    }
        


}


