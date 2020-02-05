using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.model
{
    class City
    {
        private String cityName;
        private String stateName;
        private int amountOfFlights;

        public City(String city, String state)
        {
            cityName = city;
            stateName = state;
            amountOfFlights = 0;
        }

        public String GetName()
        {
            return cityName + ", " + stateName;
        }
    }
}
