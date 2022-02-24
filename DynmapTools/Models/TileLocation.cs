namespace DynmapTools.Models
{
    internal class TileLocation : Location
    {
        public TileLocation(int longitude, int latitude, uint zoom) : base(longitude, latitude)
        {
            Zoom = zoom;
        }

        public uint Zoom { get; }
    }
}