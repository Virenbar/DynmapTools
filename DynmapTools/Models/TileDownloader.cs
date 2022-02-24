using System.Collections.Generic;

namespace DynmapTools.Models
{
    internal class TileDownloader
    {
        private readonly Dynmap Dynmap;

        public TileDownloader(Dynmap D)
        {
            Dynmap = D;
        }

        public List<string> Download(Location L, Range P, uint Zoom = 0)
        {
            //Dynmap.TilesPath
            return null;
        }
    }
    internal class TileRange
    {
    }
}