using System;

namespace AirCompany
{
    class Airplane
    {
        public int Capacity { get; private set; }
        public bool AutoPilotOn { get; set; }

        /// <summary>
        /// Fuel consuption. kg/km
        /// </summary>
        public float Consuption { get; private set; }

        public int Altitude { get; private set; }


        public static decimal TicketPrice { get; set; }
        public static int MinAltitudeAuto { get; set; }
        public static int MaxAltitudeAuto { get; set; }

        public static int Altitude1Auto { get; set; }


        private int _altitudeIncrement;

        public Airplane(int capacity, float consuption, int altitudeIncrement)
        {
            Altitude = 0;
            AutoPilotOn = false;
            Capacity = capacity;
            Consuption = consuption;
            _altitudeIncrement = altitudeIncrement;
        }

        public int Climb(int increment)
        {
            if (!AutoPilotOn) return Altitude += increment;

            if (Altitude + increment < MaxAltitudeAuto)
            {
                return Altitude += increment;
            }

            return Altitude = MaxAltitudeAuto;
        }

        public int Down(int increment)
        {
            if (AutoPilotOn)
            {
                if (Altitude - increment > MinAltitudeAuto)
                {
                    return Altitude -= increment;
                }
                if (Altitude < MinAltitudeAuto) return Altitude;
                return Altitude = MinAltitudeAuto;
            }

            if (Altitude - increment < 0) return Altitude = 0;
            return Altitude -= increment;
        }

        public int SetAltitude(int targetAlitude)
        {
            if (Altitude == targetAlitude)
            {
                if (Altitude > Altitude1Auto)
                {
                    return Alt;
                }



                ;

            }


            throw new NotImplementedException();
        }
    }
}
