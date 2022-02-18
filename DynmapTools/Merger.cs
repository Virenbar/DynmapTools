using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Collections.Generic;
using System.Linq;

namespace DynmapTools
{
    internal class Merger
    {
        private const byte Size = 128;

        private void ff()
        {
            List<(int X, int Y)> T = Enumerable.Range(0, 100).SelectMany(X => Enumerable.Range(0, 100), (X, Y) => (X, Y)).ToList();

            using (var I = new Image<Rgba32>(Size * 100, Size * 100))
            {
                foreach (var P in T)
                {
                    I.Mutate(O =>
                    {
                        using (var II = Image.Load("I.png"))
                        {
                            O.DrawImage(II, new Point(P.X * Size, P.Y * Size), 1);
                        }
                    });
                }
                I.SaveAsPng("O.png");
            }
        }
    }
}