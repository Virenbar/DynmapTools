namespace DynmapTools
{
    internal class Location
    {
        public Location(int longitude, int latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public int Longitude { get; set; }
        public int Latitude { get; set; }
    }
}