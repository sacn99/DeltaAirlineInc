using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.model
{
    class VisitCounter
    {
        private List<Flight> flights;

        private double proporcion;

        public VisitCounter()
        {
            flights = new List<Flight>();
            proporcion = 0.0;
        }

        public List<Flight> GetFlights()
        {
            return flights;
        }

        public double GetProportion()
        {
            return proporcion;
        }
    }
}
