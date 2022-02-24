using System;
using System.Linq;

namespace DynmapTools.Models
{
    internal record Point(int X, int Y, int Z)
    {
        public static Point Parse(string point)
        {
            var S = point.Split(new[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            if (S.Count != 3) { throw new ArgumentException($"Invalid point argument: {point}", nameof(point)); }
            return new Point(S[0], S[1], S[2]);
        }
    }
}