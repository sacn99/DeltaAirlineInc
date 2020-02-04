using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.model
{
    class Flight
    {
        private DateTime date;
        private int delay;
        private Boolean cancelled;

        private City destination;
        private City origin;

        public Flight(DateTime date, int delay, City dest, City orig, Boolean cancel)
        {
            this.date = date;
            this.delay = delay;
            destination = dest;
            origin = orig;
            cancelled = cancel;
        }

        public Boolean SameRelationWithCity(Flight flight)
        {
            Boolean relation = flight.GetDestination().Equals(destination); 
            relation = relation || flight.GetDestination().Equals(origin);
            relation = relation || flight.GetOrigin().Equals(origin);
            relation = relation || flight.GetOrigin().Equals(destination);
            return relation;
        }

        public Boolean GetCancelled()
        {
            return cancelled;
        }
        public City GetDestination()
        {
            return destination;
        }

        public DateTime GetDate()
        {
            return date;
        }
        public City GetOrigin()
        {
            return origin;
        }

        public int GetDelay()
        {
            return delay;
        }
        
    }
}
