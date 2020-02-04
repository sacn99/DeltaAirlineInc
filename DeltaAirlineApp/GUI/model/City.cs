using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.model
{
    class City
    {
        private double latitude;
        private double longitude;
        private String cityName;
        private String stateName;
        private int amountOfFlights;
        private Boolean tourist;



        public City(double lat, double lon, String city, String state, Boolean tourist)
        {
            latitude = lat;
            longitude = lon;
            cityName = city;
            stateName = state;
            amountOfFlights = 0;
            this.tourist = tourist;
        }

        public String GetNameCity()
        {
            return cityName;
        }

        public String GetName()
        {
            return cityName + ", " + stateName;
        }

        public Boolean GetTourist()
        {
            return tourist;
        }

        public double GetLatitude()
        {
            return latitude;
        }

        public double GetLongitude()
        {
            return longitude;
        }

    }
}
