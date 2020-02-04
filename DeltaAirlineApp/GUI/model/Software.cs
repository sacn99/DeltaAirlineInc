using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace GUI.model
{
    class Software
    {
        private String flightFileName;
        private String biggestTourisDestinationFileName;

        private List<City> cities;
        private List<Airline> airlines;

        private String[] criterions;

        public Software()
        {
            flightFileName = "..\\..\\..\\Data\\testdata.csv";
            biggestTourisDestinationFileName = "";
            cities = new List<City>();
            airlines = new List<Airline>();
            criterions = new String[5];
            criterions[0] = "Ninguno";
            criterions[1] = "Ciudad de destino";
            criterions[2] = "Ciudad de origen";
            criterions[3] = "Retardo";
            criterions[4] = "Ciudades turisticas";
            ReaddAndAddFlights();
        }


    
        public String[] getCriterions()
        {
            return criterions;
        }

        public void ReaddAndAddFlights()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(flightFileName);

                line = "";
                //0-FlightDate, 1-Carrier, 2-Latitud, 3-Longitud, 4-OriginCityName, 5-OriginStateName, 
                //6-Latitud, 7-Longitud, 8-DestCityName, 9-DestStateName, 10-DepDelayArrDelay, 11-Cancelled
                line = sr.ReadLine();
                Console.WriteLine(line);
                while ((line = sr.ReadLine()) != null)
                {
                    ///Console.WriteLine(line);
                    String[] info = line.Split(';');

                    Console.WriteLine(line);
                    double latOrigin = double.Parse(info[2]);
                    double longOrigin = double.Parse(info[3]);
                    double latDest = double.Parse(info[2]);
                    double longDest = double.Parse(info[3]);

                    int delay = int.Parse(info[10]);

                    Boolean cancel = info[11].Equals("0");

                    //search airline retunr airline or null
                    //false create  return new airline

                    Airline airline = searchAirline(info[1]); 
                    if(airline == null)
                    {
                        airline = new Airline(info[1], info[1]);
                        airlines.Add(airline);
                    }

                    City orig = SearchCity(latOrigin, longOrigin);
                    if (orig == null)
                    {   //City(double lat, double lon, String city, String state, Boolean tourist)
                        orig = new City(latOrigin, longOrigin, info[4], info[5], false);
                        cities.Add(orig);
                    }
                    City dest = SearchCity(latDest, longDest);
                    if (dest == null)
                    {
                        dest = new City(latDest, longDest, info[8], info[9], false);
                        cities.Add(dest);
                    }

                    DateTime date = DateTime.Parse(info[0]);

                    //Flight(DateTime date, int delay, City dest, City orig, Boolean cancel)
                    airline.GetFlights().Add(new Flight(date, delay, dest, orig, cancel));

                }

                sr.Close();
                //Console.ReadLine();
                Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        //retorna la aerolinea que corresponde al codigo entregado por parametro, si no lo encuentra retorna null
        public Airline searchAirline(String airlineCode)
        {
            Airline airline = null;
            Boolean flag = false;
            for(int num = 0; num < airlines.Count && !flag; num++)
            {
                if (airlines[num].GetCode().Equals(airlineCode))
                {
                    airline = airlines[num];
                }
            }
            return airline;
        }
        
        //busca la ciudad correspondiente a la latitud y longitud dada por parametro, si no la encuentra retorna null
        public City SearchCity(double lat, double lon)
        {
            City city = null;
            Boolean flag = false;
            for (int num = 0; num < cities.Count && !flag; num++)
            {
                if (cities[num].GetLatitude() == lat && cities[num].GetLongitude() == lon)
                {
                    city = cities[num];
                }
            }
            return city;
        }

        public List<String> GetNamesAirlines()
        {
            List<String> airlinesNames = new List<String>();
            foreach (Airline airline in airlines)
            {
                airlinesNames.Add(airline.GetName());
            }
            return airlinesNames;
        }

        public List<String> GetNameCities()
        {
            List<String> nameCitiesDest = new List<String>();
            foreach(City city in cities)
            {
                nameCitiesDest.Add(city.GetName());
            }
            return nameCitiesDest;
        }

        public List<String> GetNameTouristCities()
        {
            List<String> nameTouristCities = new List<String>();
            foreach (City city in cities)
            {
                if (city.GetTourist())
                {
                    nameTouristCities.Add(city.GetName());
                }
                
            }
            return nameTouristCities;
        }

        /*
         * criterions[0] = "Ninguno";
            criterions[1] = "Ciudad de destino";
            criterions[2] = "Ciudad de origen";
            criterions[3] = "Retardo";
            criterions[4] = "Ciudades turisticas";*/

        public void Filtro(String criterio, String type)
        {
            if (criterio.Equals(criterions[1]))
            {
                foreach(Airline airline in airlines)
                {
                    airline.Destination(type);
                }
            }else if (criterio.Equals(criterions[2]))
            {
                foreach (Airline airline in airlines)
                {
                    airline.Origin(type);
                }
            }
            else if (criterio.Equals(criterions[3]))
            {
                Boolean delay = type.Equals("Con retraso");
                foreach (Airline airline in airlines)
                {
                    airline.DelayedFlights(delay);
                }
            }
            else if(criterio.Equals(criterions[4]))
            {

            }
            else
            {

            }
        }

        
        

    }
}
