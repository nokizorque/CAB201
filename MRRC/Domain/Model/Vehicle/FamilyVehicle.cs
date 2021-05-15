﻿namespace MRRC
{
    /// <summary>
    /// Family vehicle entity
    /// Lewis Watson 2020
    /// </summary>
    public class FamilyVehicle : Vehicle
    {
        public new const double Default_Daily_Rate = 80;

        public FamilyVehicle(
            string vehicleRego,
            string make,
            string model,
            int year,
            int numSeats = Default_Num_Seats,
            TransmissionType transmission = Default_Transmission_Type,
            FuelType fuel = Default_Fuel_Type,
            bool GPS = Default_GPS,
            bool sunRoof = Default_Sun_Roof,
            double dailyRate = Default_Daily_Rate,
            string colour = Default_Colour
        ) : base(
            vehicleRego,
            VehicleGrade.Family,
            make,
            model,
            year,
            numSeats,
            transmission,
            fuel,
            GPS,
            sunRoof,
            dailyRate,
            colour
        )
        { }
    }
}
