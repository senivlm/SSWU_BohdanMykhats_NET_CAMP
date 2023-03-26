using System.Data.Common;
using System.Numerics;
using System.Text;

namespace LongestHorizontalLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixLineLength mtl = new(20,20);
            mtl.FillWithRandom(15);
            Console.WriteLine(mtl);
            
            Console.WriteLine($"Longest line width: {mtl.FindLongestLine(out HalfByte colour, out int[] x1, out int y)}" +
                $", range {x1[0]} - {x1[1]}, y={y}, colour={colour}");
        }
    }


}