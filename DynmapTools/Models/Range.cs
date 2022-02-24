using System;
using System.Linq;

namespace DynmapTools.Models
{
    internal record Range(uint Top, uint Right, uint Bottom, uint Left)
    {
        public Range(uint All) : this(All, All, All, All) { }
        public Range(uint V, uint H) : this(V, H, V, H) { }
        static public Range Parse(string range)
        {
            var S = range.Split(new[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries).Select(uint.Parse).ToList();
            return S.Count switch
            {
                4 => new Range(S[0], S[1], S[2], S[3]),
                2 => new Range(S[0], S[1]),
                1 => new Range(S[0]),
                _ => throw new ArgumentException($"Invalid range argument: {range}", nameof(range))
            };
        }
        public override string ToString() => $"[{Top},{Right},{Bottom},{Left}]";
    }
}