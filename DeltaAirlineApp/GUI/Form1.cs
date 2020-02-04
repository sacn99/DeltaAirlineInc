using GUI.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace GUI
{
    public partial class Form1 : Form
    {

        private Software software;

        GMapOverlay markerOverlay;
        GMarkerGoogle marker;

        double latInicial = 4.570868;
        double longinicial = -74.2973328;

        public Form1()
        {
            software = new Software();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            software.Filtro(cmbCriterion1.Text, cmbCriterion1Select.Text);
            software.Filtro(cmbCriterion2.Text, cmbCriterion2Select.Text);
            software.Filtro(cmbCriterion3.Text, cmbCriterion3Select.Text);

            addMarkers(gMapControl1, cmbGMap1.Text);
            addMarkers(gMapControl2, cmbGMap2.Text);
            addMarkers(gMapControl3, cmbGMap3.Text);
            addMarkers(gMapControl4, cmbGMap4.Text);

        }



        private void addMarkers(GMapControl gMap, String airline)
        {
            int cant = software.searchAirline(airline).GetVisits().Count;

            Console.WriteLine(cant);
            for (int i = 0; i< cant; i++)
            {
                Console.WriteLine("for: "+i);
                double prop = software.searchAirline(airline).GetVisits()[i].GetProportion();
                double lat = software.searchAirline(airline).GetVisits()[i].GetFlights()[0].GetDestination().GetLatitude();
                double lon = software.searchAirline(airline).GetVisits()[i].GetFlights()[0].GetDestination().GetLongitude();
                
                markerOverlay = new GMapOverlay("Marcador");
                if(prop < 3)
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
                }
                else if(prop < 6)
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.yellow);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
                }

                markerOverlay.Markers.Add(marker);
                gMap.Overlays.Add(markerOverlay);

                lat = software.searchAirline(airline).GetVisits()[i].GetFlights()[0].GetOrigin().GetLatitude();
                lon = software.searchAirline(airline).GetVisits()[i].GetFlights()[0].GetOrigin().GetLongitude();

                markerOverlay = new GMapOverlay("Marcador");
                if (prop < 3)
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
                }
                else if (prop < 6)
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.yellow);
                }
                else
                {
                    marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
                }
                markerOverlay.Markers.Add(marker);
                gMap.Overlays.Add(markerOverlay);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, longinicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);

            cmbCriterion1.Items.AddRange(software.getCriterions());
            cmbCriterion2.Items.AddRange(software.getCriterions());
            cmbCriterion3.Items.AddRange(software.getCriterions());

            foreach(String airline in software.GetNamesAirlines())
            {
                cmbGMap1.Items.Add(airline);
                cmbGMap2.Items.Add(airline);
                cmbGMap3.Items.Add(airline);
                cmbGMap4.Items.Add(airline);
            }
            
        }

        private void loadComboBoxes(ComboBox comboBox, String select)
        {
            comboBox.Items.Clear();
            if (select.Equals("Ciudad de destino") || select.Equals("Ciudad de origen"))
            {
                List<String> list = software.GetNameCities();
                foreach (String city in list)
                {
                    comboBox.Items.Add(city);
                }

            }
            else if (select.Equals("Retardo"))
            {
                comboBox.Items.Add("Con retraso");
               comboBox.Items.Add("Sin retraso");
            }
            else if (select.Equals("Ciudades Turisticas"))
            {
                List<String> list = software.GetNameTouristCities();
                foreach (String city in list)
                {
                    comboBox.Items.Add(city);
                }
            }
        }

        private void gMapPrincipal_Load(object sender, EventArgs e)
        {
            gMapPrincipal.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapPrincipal.SetPositionByKeywords("Aberdeen, South Dakota");
            
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(3.4372201, -76.5224991), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            gMapPrincipal.Overlays.Add(markerOverlay);

        }

        private void cmbCriterion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxes(cmbCriterion1Select, cmbCriterion1.Text);
        }

        private void cmbCriterion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxes(cmbCriterion2Select, cmbCriterion2.Text);
        }

        private void cmbCriterion3_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxes(cmbCriterion3Select, cmbCriterion3.Text);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Aberdeen, South Dakota");
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(3.4372201, -76.5224991), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void gMapControl2_Load(object sender, EventArgs e)
        {
            gMapControl2.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl2.SetPositionByKeywords("Aberdeen, South Dakota");
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(3.4372201, -76.5224991), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            gMapControl2.Overlays.Add(markerOverlay);
        }

        private void gMapControl4_Load(object sender, EventArgs e)
        {
            gMapControl4.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl4.SetPositionByKeywords("Aberdeen, South Dakota");

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(3.4372201, -76.5224991), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            gMapControl4.Overlays.Add(markerOverlay);
        }

        private void gMapControl3_Load(object sender, EventArgs e)
        {
            gMapControl3.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl3.SetPositionByKeywords("Aberdeen, South Dakota");

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(3.4372201, -76.5224991), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);
            gMapControl3.Overlays.Add(markerOverlay);
        }
    }
}
