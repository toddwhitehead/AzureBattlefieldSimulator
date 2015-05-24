//********************************************************* 
// 
//    Copyright (c) Microsoft. All rights reserved. 
//    This code is licensed under the Microsoft Public License. 
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF 
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY 
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR 
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT. 
// 
//********************************************************* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorEventGenerator
{
    public class Sensor
    {
        public string EventTime;
        public int ObjectId;


        public string ObjectTypeName; //eg BRDM-2
        public int CountryId;
        public decimal Latitude;
        public decimal Longtitude;        
        public int Altitude;
        public int Speed;

        static Random R = new Random();
        
        // Dummy List of aircraft callsigns
        static string[] aircraftNames = new[] { "A10C", "BRDM-2", "Infantry M4", "Mig 29" };
        
        public static Sensor Generate()
        {
            return new Sensor { EventTime = DateTime.UtcNow.ToString(), ObjectTypeName = aircraftNames[R.Next(aircraftNames.Length)], Altitude = R.Next(0, 25000), Latitude = R.Next(42,44), Longtitude = R.Next(40,46), Speed = R.Next(0, 300) };
        }
    }
}
