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

        private List<City> cities;
        private List<Airline> airlines;

        private String[] criterions;

        public Software()
        {
            flightFileName = "..\\..\\..\\Data\\testdata.csv";
            cities = new List<City>();
            airlines = new List<Airline>();
            criterions = new String[4];
            criterions[0] = "Ninguno - mostar todos";
            criterions[1] = "Ciudad de origen";
            criterions[2] = "Retardo positivo";
            criterions[3] = "Retardo negativo";
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
                // 0-FlightDate, 1-Carrier, 2-OriginCityName, 3-OriginStateName, 
                // 4-DestCityName, 5-DestStateName, 6-DepDelay, 7-ArrDealy, 8-Cancelled
                //Console.WriteLine(line);
                while ((line = sr.ReadLine()) != null)
                {
                    ///Console.WriteLine(line);
                    String[] info = line.Split(',');

                    //search airline retunr airline or null
                    //false create  return new airline

                    Airline airline = SearchAirline(info[1]); 
                    if(airline == null)
                    {
                        airline = new Airline(info[1], info[1]);
                        airlines.Add(airline);
                    }

                    City orig = SearchCity(info[2]);
                    if (orig == null)
                    {   //City(String city, String state)
                        orig = new City(info[2], info[3]);
                        cities.Add(orig);
                    }
                    City dest = SearchCity(info[4]);
                    if (dest == null)
                    {
                        dest = new City(info[4], info[5]);
                        cities.Add(dest);
                    }

                    DateTime date = DateTime.Parse(info[0]);
                    int cancel = Int32.Parse(info[8]);

                    //Flight(DateTime date, int delay, City dest, City orig, Boolean cancel)
                    airline.GetFlights().Add(new Flight(date, orig, dest, Int32.Parse(info[6]), cancel == 1 ? true : false));
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
        public Airline SearchAirline(String airlineCode)
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
        public City SearchCity(String name)
        {
            City city = null;
            Boolean flag = false;
            for (int num = 0; num < cities.Count && !flag; num++)
            {
                if (cities[num].Equals(name))
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

        public void Filtro(String criterio, String type)
        {
           if (criterio.Equals(criterions[1]) && !type.Equals(""))
            {
                foreach (Airline airline in airlines)
                {
                    airline.Origin(type);
                }
            }
            else if (criterio.Equals(criterions[2]) && !type.Equals(""))
            {
                Boolean delay = type.Equals("Con retraso");
                foreach (Airline airline in airlines)
                {
                    airline.DelayedFlights(delay);
                }
            }
            else if (criterio.Equals("Ninguno - mostar todos"))
            {
                foreach (Airline airline in airlines)
                {
                    airline.AddAll();
                }
            }

        }

        
        

    }
}
