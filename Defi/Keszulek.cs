using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defi
{
    class Keszulek
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double latitude;

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        private double longitude;

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private double dist;

        public double Dist
        {
            get { return dist; }
            set { dist = value; }
        }

        public Keszulek(int id, string name, double latitude, double longitude, string tel, string address)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.tel = tel;
            this.address = address;
        }

        public double DistCalc(double x, double y)
        {
            double a = (x - longitude) * Math.Cos((y + latitude) / 2);
            double b = latitude - y;

            double distance = Math.Sqrt(a * a + b * b) * 6371;

            return distance;
            
        }
    }
}

