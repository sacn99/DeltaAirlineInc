using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GUI.model
{
    class Airline
    {

        private String code;
        private String name;
        private int count;
        private List<Flight> flights;

        private List<VisitCounter> visits; 

        //private Hashtable flightsDest;

        public Airline(String code, String name)
        {
            this.code = code;
            this.name = name;
            flights = new List<Flight>();
            visits = new List<VisitCounter>();
            //flightsDest = new Hashtable();
        }

        public void ActualiceCounter()
        {
            int countt = 0;
            foreach(VisitCounter visit in visits)
            {
                countt = countt + visit.GetFlights().Count;
            }
        }

        public int GetCounter()
        {
            return count;
        }

        public List<VisitCounter> GetVisits()
        {
            return visits;
        }

        public List<Flight> GetFlights()
        {
            return flights;
        }

        public String GetCode()
        {
            return code;
        }

        public String GetName()
        {
            return name;
        }

        public void DelayedFlights(Boolean delay)
        {
            foreach (Flight flight in flights)
            {
                if (flight.GetDelay() > 0) ///buscar 
                {
                    VisitCounter visit = SearchVist(flight);
                    visit.GetFlights().Add(flight);
                }
            }
        }
        public void AddAll()
        {
            foreach (Flight flight in flights)
            {
                VisitCounter visit = SearchVist(flight);
                visit.GetFlights().Add(flight);
            }
        }

        public void Destination(String destination)
        {
            foreach (Flight flight in flights)
            {
                if (flight.GetDestination().GetName().Equals(destination))
                {
                    VisitCounter visit = SearchVist(flight);
                    visit.GetFlights().Add(flight);
                }
            }
        }

        public void Origin(String origin)
        {
            foreach (Flight flight in flights)
            {
                if (flight.GetOrigin().GetName().Equals(origin))
                {
                    VisitCounter visit = SearchVist(flight);
                    visit.GetFlights().Add(flight);
                }
            }
        }

        public void Date(DateTime date)
        {
            foreach (Flight flight in flights)
            {
                if (flight.GetDate().Equals(date))
                {
                    VisitCounter visit = SearchVist(flight);
                    visit.GetFlights().Add(flight);
                }
            }
        }

        public VisitCounter SearchVist(Flight flight)
        {
            VisitCounter visit = null;
            foreach(VisitCounter counter in visits)
            {
                if (counter.GetFlights()[0].SameRelationWithCity(flight))
                {
                    visit = counter;
                }
            }
            if(visit == null)
            {
                visit = new VisitCounter();
                visits.Add(visit);

            }
            return visit;
        }

        /*
       public List<Flight> DelayedFlights(String airline)
       {
            List<Flight> flights = new List<String>();
           foreach (City city in cities)
           {
               if (city.GetTourist())
               {
                   nameTouristCities.Add(city.GetName());
               }

           }
           return nameTouristCities;
       }

       public List<Flight> Destination(String destination, String airline)
       {

       }

       public List<Flight> Origin(String origin, String airline)
       {

       }

       public List<Flight> Date(DateTime date, String airline)
       {

       }

       public List<Flight> BiggestTouristDestination(String biggestDestination, String airline)
       {

       }
       */

    }
}
